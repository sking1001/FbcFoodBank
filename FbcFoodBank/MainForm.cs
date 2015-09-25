using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FbcFoodBank
{
    public partial class MainForm : Form
    {
        private bool dataChanged = false;
        public bool DataChanged
        {
            get { return dataChanged; }
            set
            {
                dataChanged = value;
                EnableSaveItems(value);
            }
        }

        private string formError = null;
        public string FormError
        {
            get { return formError; }
            set
            {
                formError = value;
                EnableDatabaseItems(value == null);
            }
        }

        private bool nameChanged = false;
        public bool NameChanged
        {
            get { return nameChanged; }
            set
            {
                nameChanged = value;
                if (nameChanged)
                {
                    this.visitsDataGridView.Enabled = false;
                    if (this.visitsBindingSource.List.Count > 0)
                        this.errorProvider1.SetError(this.visitsDataGridView, Properties.Resources.CantEditVisits);
                }
                else
                {
                    this.visitsDataGridView.Enabled = true;
                    this.errorProvider1.SetError(this.visitsDataGridView, null);
                }
            }
        }

        private bool visitChanged = false;
        public bool VisitChanged
        {
            get { return visitChanged; }
            set
            {
                visitChanged = value;
                if (visitChanged)
                {
                    this.nameTextBox.Enabled = false;
                    this.bindingNavigatorAddNewItem.Enabled = false;
                    this.contactsBindingNavigator.AddNewItem = null;
                    this.errorProvider1.SetError(this.nameTextBox, Properties.Resources.CantEditName);
                }
                else
                {
                    this.nameTextBox.Enabled = true;
                    this.bindingNavigatorAddNewItem.Enabled = true;
                    this.contactsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
                    this.errorProvider1.SetError(this.nameTextBox, null);
                }
            }
        }

        private bool contactBeingDeleted = false;

        // This is to avoid multiple prompts to confirm EACH row deletion when one cancels
        // a deletion of multiple rows.
        private int visitsToIgnoreUserDeletingRow = 0;

        public string DataDirectory
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                    return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory;
                else
                    return Application.StartupPath;
            }
        }

        public string DataFile
        {
            get { return this.DataDirectory + @"\" + Properties.Resources.DatabaseName; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        bool LoadDatabase()
        {
            bool ret = true;

            try
            {
                this.fbcFoodBankDataSet.Clear();
                this.contactsTableAdapter.Fill(this.fbcFoodBankDataSet.Contacts);
                this.visitsTableAdapter.Fill(this.fbcFoodBankDataSet.Visits);

                foreach (FbcFoodBankDataSet.VisitsRow row in this.fbcFoodBankDataSet.Visits)
                {
                    if (row.IsAdults_in_HomeNull())
                        row.Adults_in_Home = row.ContactsRow.Adults_in_Home;
                    if (row.IsChildren_in_HomeNull())
                        row.Children_in_Home = row.ContactsRow.Children_in_Home;
                }
                this.visitsTableAdapter.Update(this.fbcFoodBankDataSet.Visits);

                this.visitsDataGridView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }
            finally
            {
                this.DataChanged = false;
                this.NameChanged = false;
                this.VisitChanged = false;
                this.nameSearch.Text = string.Empty;
            }

            return ret;
        }

        void CompactAndRepair()
        {
            // The |DataDirectory| token will not work here:
            string connectionString = Properties.Settings.Default.FbcFoodBankConnectionString;
            connectionString = connectionString.Replace("|DataDirectory|", DataDirectory);

            string tempDataFile = this.DataDirectory + @"\" + System.Guid.NewGuid().ToString();

            // Create an inctance of a Jet Replication Object
            object jro = Activator.CreateInstance(Type.GetTypeFromProgID("JRO.JetEngine"));

            // Filling Parameters array
            // Change "Jet OLEDB:Engine Type=5" to an appropriate value
            // or leave it as is if your db is JET4X format (access 2000,2002)
            // (yes, jetengine5 is for JET4X, no misprint here)
            object[] parms = new object[]
            {
                connectionString,
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + tempDataFile + ";Jet OLEDB:Engine Type=5"
            };

            // Invoke a CompactDatabase method of a JRO object
            // pass parms array
            jro.GetType().InvokeMember("CompactDatabase", System.Reflection.BindingFlags.InvokeMethod, null, jro, parms);

            // Database is now compacted to a new file, tempDataFile,
            // so let's move it over the real data file.
            System.IO.File.Delete(DataFile);
            System.IO.File.Move(tempDataFile, DataFile);

            // Clean up (just in case)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(jro);
            jro = null;
        }

        bool PromptSaveChanges()
        {
            bool ret = true;

            DialogResult result = MessageBox.Show(Properties.Resources.SaveChangesPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ret = SaveChanges();
            else if (result == DialogResult.Cancel)
                ret = false;

            return ret;
        }

        bool PromptDiscardChanges()
        {
            bool ret = true;

            DialogResult result = MessageBox.Show(Properties.Resources.DiscardPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ret = true;
            else if (result == DialogResult.No)
                ret = false;

            return ret;
        }

        bool PromptCloseReports()
        {
            bool ret = true;

            DialogResult result = MessageBox.Show(Properties.Resources.CloseReportsPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                ret = Report.CloseAllReports();
            else if (result == DialogResult.No)
                ret = false;

            return ret;
        }

        bool SaveChanges()
        {
            bool ret = true;

            if (FormError == null)
            {
                try
                {
                    this.Validate();

                    if (NameChanged)
                    {
                        this.contactsBindingSource.EndEdit();
                        this.contactsTableAdapter.Update(this.fbcFoodBankDataSet.Contacts);
                        NameChanged = false;
                    }
                    else
                    {
                        // Save Visits (always save the child table first):
                        this.visitsBindingSource.EndEdit();
                        this.visitsTableAdapter.Update(this.fbcFoodBankDataSet.Visits);
                        VisitChanged = false;

                        // Here, the ID for a new visit could be off in the dataset, because of the
                        // possible bogus new detached entry caused from the user clicking on the last
                        // entry.  Loading from the DB is a way to resolve this wrong ID.
                        this.visitsTableAdapter.Fill(this.fbcFoodBankDataSet.Visits);

                        // Save Contacts:
                        this.contactsBindingSource.EndEdit();
                        this.contactsTableAdapter.Update(this.fbcFoodBankDataSet.Contacts);
                    }

                    this.DataChanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ret = false;
                }
            }
            else
            {
                MessageBox.Show(string.Format(Properties.Resources.CantSaveChanges, FormError), Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }

            return ret;
        }

        void EnableSaveItems(bool enabledVal)
        {
            if (FormError != null)
                enabledVal = false;
            saveToolStripMenuItem.Enabled = enabledVal;
            contactsBindingNavigatorSaveItem.Enabled = enabledVal;
        }

        void EnableDatabaseItems(bool enabledVal)
        {
            // Navigator action items:
            this.contactsBindingNavigator.MoveFirstItem = (enabledVal) ? this.bindingNavigatorMoveFirstItem : null;
            this.contactsBindingNavigator.MovePreviousItem = (enabledVal) ? this.bindingNavigatorMovePreviousItem : null;
            this.contactsBindingNavigator.PositionItem = (enabledVal) ? this.bindingNavigatorPositionItem : null;
            this.contactsBindingNavigator.MoveNextItem = (enabledVal) ? this.bindingNavigatorMoveNextItem : null;
            this.contactsBindingNavigator.MoveLastItem = (enabledVal) ? this.bindingNavigatorMoveLastItem : null;
            if (!this.VisitChanged)
                this.contactsBindingNavigator.AddNewItem = (enabledVal) ? this.bindingNavigatorAddNewItem : null;

            // Navigator controls:
            this.bindingNavigatorMoveFirstItem.Enabled = enabledVal;
            this.bindingNavigatorMovePreviousItem.Enabled = enabledVal;
            this.bindingNavigatorPositionItem.Enabled = enabledVal;
            this.bindingNavigatorMoveNextItem.Enabled = enabledVal;
            this.bindingNavigatorMoveLastItem.Enabled = enabledVal;
            if (!this.VisitChanged)
                this.bindingNavigatorAddNewItem.Enabled = enabledVal;

            // Menu items:
            this.findToolStripMenuItem.Enabled = enabledVal;
            this.addVisitNowToolStripMenuItem.Enabled = enabledVal;
            this.inactiveContactsToolStripMenuItem.Enabled = enabledVal;

            // Toolstrip items:
            this.nameSearch.Enabled = enabledVal;
            this.addVisitNowButton.Enabled = enabledVal;
            this.showHideInactiveButton.Enabled = enabledVal;

            // Form controls:
            if (!this.deceasedCheckBox.Checked)
                this.inactiveCheckBox.Enabled = enabledVal;
            this.deceasedCheckBox.Enabled = enabledVal;
            if (!NameChanged)
                this.visitsDataGridView.Enabled = enabledVal;
        }

        void ValidateName()
        {
            this.FormError = null;
            if (!this.VisitChanged)
                this.errorProvider1.SetError(nameTextBox, null);

            if (this.nameTextBox.Text.Length == 0)
                FormError = Properties.Resources.NameEmpty;
            else
            {
                int count = 0;
                foreach (DataRowView rowView in this.contactsBindingSource.List)
                {
                    FbcFoodBankDataSet.ContactsRow row = (FbcFoodBankDataSet.ContactsRow)rowView.Row;
                    if (row.Name == this.nameTextBox.Text)
                        ++count;
                }
                if (count > 1)
                {
                    FormError = string.Format(Properties.Resources.NameExists, this.nameTextBox.Text);
                    this.errorProvider1.SetError(this.nameTextBox, FormError);
                }
            }

            if (FormError != null)
                EnableSaveItems(false);
            else
                EnableSaveItems(true);
        }

        void RefreshInactive()
        {
            this.contactsBindingSource.EndEdit();

            if (this.showHideInactiveButton.Checked)
            {
                this.contactsBindingSource.Filter = null;
                this.showHideInactiveButton.Image = Properties.Resources.inactive;
                this.showHideInactiveButton.Text = "Inactive Too";
            }
            else
            {
                this.contactsBindingSource.Filter = "Inactive=false";
                this.showHideInactiveButton.Image = Properties.Resources.active;
                this.showHideInactiveButton.Text = "Only Active";
            }
        }

        void AddVisitNow()
        {
            bool go = true;

            foreach (DataRowView rowView in this.visitsBindingSource.List)
            {
                FbcFoodBankDataSet.VisitsRow row = (FbcFoodBankDataSet.VisitsRow)rowView.Row;
                try
                {
                    if (row.Date.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        DialogResult result = MessageBox.Show(Properties.Resources.DuplicateVisitPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                            go = false;
                        break;
                    }
                }
                catch
                {
                    // row.Date could throw an exception if it is NULL
                }

            }

            if (go && this.DataChanged)
            {
                DialogResult result = MessageBox.Show(Properties.Resources.AddVisitNowPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    go = false;
            }

            if (go)
            {
                // When the visit is added, this.nameTextBox will be disabled, and the focus will be lost.
                bool nameHadFocus = this.nameTextBox.Focused;

                // This is necessary here, because there could be a bogus new detached entry
                // caused from the user clicking on the last entry, or if there are no visits
                // currently in the grid.
                SaveChanges();

                DataRowView rowView = (DataRowView)this.visitsBindingSource.AddNew();
                FbcFoodBankDataSet.VisitsRow newVisit = (FbcFoodBankDataSet.VisitsRow)rowView.Row;
                newVisit.Date = DateTime.Now;
                newVisit.Children_in_Home = (int)this.children_in_HomeNumericUpDown.Value;
                newVisit.Adults_in_Home = (int)this.adults_in_HomeNumericUpDown.Value;

                SaveChanges();
                this.visitsDataGridView.AutoResizeColumns();

                if (nameHadFocus)
                    this.nameTextBox.Focus();
            }
        }

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.AppTitle;
            this.aboutToolStripMenuItem.Text = "About " + Properties.Resources.AppTitle + "...";

            if (!LoadDatabase())
                this.Close();

            this.fbcFoodBankDataSet.Tables["Contacts"].ColumnChanged += new DataColumnChangeEventHandler(MainForm_ColumnChanged);
            this.fbcFoodBankDataSet.Tables["Contacts"].TableNewRow += new DataTableNewRowEventHandler(MainForm_TableNewRow);
            this.fbcFoodBankDataSet.Tables["Contacts"].RowDeleted += new DataRowChangeEventHandler(MainForm_RowDeleted);

            this.fbcFoodBankDataSet.Tables["Visits"].ColumnChanged += new DataColumnChangeEventHandler(MainForm_ColumnChanged);
            this.fbcFoodBankDataSet.Tables["Visits"].TableNewRow += new DataTableNewRowEventHandler(MainForm_TableNewRow);
            this.fbcFoodBankDataSet.Tables["Visits"].RowDeleted += new DataRowChangeEventHandler(MainForm_RowDeleted);
        }

        void MainForm_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Row.GetType() == typeof(FbcFoodBankDataSet.ContactsRow))
            {
                if (e.Column.ColumnName == "Name")
                    this.NameChanged = true;
            }
            else if (e.Row.GetType() == typeof(FbcFoodBankDataSet.VisitsRow))
            {
                // I don't care if the name changed.  This is a relational field
                // and is handled in the contacts table.
                if (e.Column.ColumnName != "Name")
                    this.VisitChanged = true;
            }
            this.DataChanged = true;
        }

        void MainForm_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            if (e.Row.GetType() == typeof(FbcFoodBankDataSet.ContactsRow))
                this.NameChanged = true;
            else if (e.Row.GetType() == typeof(FbcFoodBankDataSet.VisitsRow))
                this.VisitChanged = true;
            this.DataChanged = true;
        }

        void MainForm_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            if (!this.NameChanged && !this.contactBeingDeleted && e.Row.GetType() == typeof(FbcFoodBankDataSet.VisitsRow))
                this.VisitChanged = true;
            this.DataChanged = true;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.nameTextBox.DataBindings[0].WriteValue();
            this.ValidateName();
        }

        private void addVisitNowButton_Click(object sender, EventArgs e)
        {
            AddVisitNow();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.DeleteContactPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.contactBeingDeleted = true;
                this.contactsBindingSource.RemoveCurrent();
                this.ValidateName();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DataChanged)
                e.Cancel = !PromptSaveChanges();
        }

        private void contactsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (this.NameChanged)
            {
                if (this.visitsBindingSource.List.Count > 0)
                    this.errorProvider1.SetError(this.visitsDataGridView, Properties.Resources.CantEditVisits);
                else
                    this.errorProvider1.SetError(this.visitsDataGridView, null);
            }

            this.visitsDataGridView.AutoResizeColumns();
        }

        private void nameSearch_TextChanged(object sender, EventArgs e)
        {
            if (nameSearch.Text.Length != 0)
            {
                try
                {
                    DataTable dt = this.fbcFoodBankDataSet.Tables["Contacts"];
                    DataRow[] rows = dt.Select("Name LIKE '" + nameSearch.Text + "%'", "Name");
                    foreach (FbcFoodBankDataSet.ContactsRow row in rows)
                    {
                        if (this.showHideInactiveButton.Checked || row.Inactive == false)
                        {
                            this.contactsBindingSource.Position = this.contactsBindingSource.Find("Name", row.Name);
                            break;
                        }
                    }
                }
                catch
                {
                    // The SELECT could throw an exception if there are illegal SQL characters in nameSearch.text
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool go = true;
            if (this.DataChanged)
                go = PromptDiscardChanges();
            if (Report.WindowListCount > 0)
                go = PromptCloseReports();

            if (go)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = Properties.Resources.DlgFilter;
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK && dlg.FileName != this.DataFile)
                {
                    string backupDataFile = this.DataDirectory + @"\" + System.Guid.NewGuid().ToString();

                    try
                    {
                        File.Move(this.DataFile, backupDataFile);
                        File.Copy(dlg.FileName, this.DataFile);
                        if (!LoadDatabase())
                        {
                            File.Delete(this.DataFile);
                            File.Move(backupDataFile, this.DataFile);
                            LoadDatabase();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (File.Exists(backupDataFile))
                        {
                            try
                            {
                                File.Delete(backupDataFile);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool go = true;
            if (this.DataChanged)
                go = PromptSaveChanges();
            if (Report.WindowListCount > 0)
                go = PromptCloseReports();

            if (go)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = Properties.Resources.DlgFilter;
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        this.CompactAndRepair();
                        File.Copy(this.DataFile, dlg.FileName, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameSearch.Focus();
            nameSearch.SelectAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About.AboutForm dlg = new About.AboutForm(Properties.Resources.AppTitle);
            dlg.ShowDialog();
        }

        private void visitsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void inactiveCheckBox_Click(object sender, EventArgs e)
        {
            this.inactiveCheckBox.DataBindings[0].WriteValue();
            RefreshInactive();
        }

        private void showHideInactiveButton_Click(object sender, EventArgs e)
        {
            RefreshInactive();
        }

        private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool go = true;
            if (this.DataChanged)
                go = PromptSaveChanges();

            if (go)
            {
                CreateReport dlg = new CreateReport();
                DialogResult result = dlg.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Report report = new Report(dlg.DateRange, dlg.StartDate, dlg.EndDate, dlg.SortByName, dlg.IncludeInactive, this.DataFile);
                    report.LoadAndShow();
                }
            }
        }

        private void deceasedCheckBox_Click(object sender, EventArgs e)
        {
            if (this.deceasedCheckBox.Checked)
            {
                this.deceasedCheckBox.DataBindings[0].WriteValue();
                RefreshInactive();
            }
        }

        private void deceasedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.deceasedCheckBox.Checked)
            {
                this.inactiveCheckBox.Checked = true;
                this.inactiveCheckBox.Enabled = false;
            }
        }

        private void addVisitNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVisitNow();
        }

        private void inactiveContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showHideInactiveButton.Checked = this.inactiveContactsToolStripMenuItem.Checked;
            RefreshInactive();
        }

        private void visitsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView rowView = (DataRowView)this.visitsBindingSource.Current;
            FbcFoodBankDataSet.VisitsRow row = (FbcFoodBankDataSet.VisitsRow)rowView.Row;
            if (!row.IsDateNull())
            {
                this.visitsBindingSource.EndEdit();
                if (row.RowState != DataRowState.Unchanged)
                {
                    if (row.IsChildren_in_HomeNull())
                        row.Children_in_Home = (int)this.children_in_HomeNumericUpDown.Value;
                    if (row.IsAdults_in_HomeNull())
                        row.Adults_in_Home = (int)this.adults_in_HomeNumericUpDown.Value;
                    this.visitsDataGridView.AutoResizeColumns();
                }
            }
        }

        private void visitsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (this.visitsToIgnoreUserDeletingRow == 0)
                this.visitsToIgnoreUserDeletingRow = this.DeleteSelectedVisits();
            if (this.visitsToIgnoreUserDeletingRow != 0)
                --this.visitsToIgnoreUserDeletingRow;
            e.Cancel = true;    // Always cancel...everything is handled manually
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedVisits();
        }

        private int DeleteSelectedVisits()
        {
            int rowsNotDeleted = 0;

            DataGridViewSelectedRowCollection rowsToDelete = this.visitsDataGridView.SelectedRows;
            rowsNotDeleted = rowsToDelete.Count;
            if (rowsNotDeleted > 0)
            {
                DialogResult result = MessageBox.Show(Properties.Resources.DeleteVisitsPrompt, Properties.Resources.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow rowToDelete in rowsToDelete)
                        this.visitsDataGridView.Rows.Remove(rowToDelete);
                    rowsNotDeleted = 0;
                }
            }

            return rowsNotDeleted;
        }

        private void visitsDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!this.visitsDataGridView.Rows[e.RowIndex].Selected)
                {
                    foreach (DataGridViewRow row in this.visitsDataGridView.Rows)
                        row.Selected = false;
                    this.visitsDataGridView.Rows[e.RowIndex].Selected = true;
                }
            }
        }
    }
}
