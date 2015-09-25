using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Globalization;
using System.Collections;

namespace FbcFoodBank
{
    public partial class Report : Form
    {
        private string dateRange;
        private DateTime startDate;
        private DateTime endDate;
        private bool sortByName;
        private bool includeInactive;
        private string dataFile;

        private ReportClass report;
        private LoadingReport loadingWindow;

        static private ArrayList windowList;
        static public int WindowListCount
        {
            get
            {
                if (windowList != null)
                    return windowList.Count;
                else
                    return 0;
            }
        }

        static public bool CloseAllReports()
        {
            bool ret = true;

            try
            {
                while (windowList != null && windowList.Count > 0)
                    ((Form)windowList[windowList.Count - 1]).Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ret = false;
            }

            return ret;
        }

        public Report(string dateRange, DateTime startDate, DateTime endDate,
            bool sortByName, bool includeInactive, string dataFile)
        {
            this.dateRange = dateRange;
            this.startDate = startDate;
            this.endDate = endDate;
            this.sortByName = sortByName;
            this.includeInactive = includeInactive;
            this.dataFile = dataFile;

            InitializeComponent();

            // static
            if (windowList == null)
                windowList = new ArrayList();
        }

        public void LoadAndShow()
        {
            this.loadingWindow = new LoadingReport();
            this.loadingWindow.Show();

            if (this.dateRange == "Custom")
                this.Text = string.Format("{0} - {1}", this.startDate.ToShortDateString(), this.endDate.ToShortDateString());
            else
                this.Text = this.dateRange;
            if (this.sortByName)
                this.Text += " Sorted by Name";
            if (this.includeInactive)
            {
                this.Text += " (Including Inactive)";
                this.report = this.crystalReportDocumentInactive;
            }
            else
                this.report = this.crystalReportDocument;
            this.Text += " - " + Properties.Resources.AppTitle + " Report";

            foreach (Table table in this.report.Database.Tables)
                table.Location = this.dataFile; 
            this.report.RecordSelectionFormula = this.GetRecordSelectionFormula();
            if (this.sortByName)
            {
                // By default, SortFields[0] is the group sort, SortFields[1] is Visits.Date (just the date part, ignoring time),
                // and SortFields[2] is Visits.Id
                this.report.DataDefinition.SortFields[2].Field = this.report.Database.Tables["Visits"].Fields["Name"];
            }
            this.crystalReportViewer.ReportSource = this.report;

            // To Remove the annoying "Main Report" tab:
            foreach (Control control in this.crystalReportViewer.Controls)
            {
                if (string.Compare(control.GetType().Name, "PageView", true, CultureInfo.InvariantCulture) == 0)
                {
                    TabControl tab = (TabControl)((PageView)control).Controls[0];

                    tab.ItemSize = new Size(0, 1);
                    tab.SizeMode = TabSizeMode.Fixed;
                    tab.Appearance = TabAppearance.Buttons;
                }
            }

            this.Show();
            windowList.Add(this);
        }

        protected override void OnLoad(EventArgs args)
        {
            base.OnLoad(args);
            Application.Idle += new EventHandler(OnLoaded);
        }

        private void OnLoaded(object sender, EventArgs args)
        {
            Application.Idle -= new EventHandler(OnLoaded);
            this.loadingWindow.Close();
        }

        private string GetRecordSelectionFormula()
        {
            string ret = string.Empty;

            string recordSelectionFormat = "{{@Date Only}} in DateTime({0}, {1}, {2}) to DateTime({3}, {4}, {5})";
            if (dateRange != "All Dates")
            {
                ret = string.Format(recordSelectionFormat,
                    this.startDate.Year.ToString(), this.startDate.Month.ToString(), this.startDate.Day.ToString(),
                    this.endDate.Year.ToString(), this.endDate.Month.ToString(), this.endDate.Day.ToString());
            }

            if (!includeInactive)
            {
                if (ret.Length != 0)
                    ret += " AND ";
                ret += "NOT {Contacts.Inactive}";
            }

            return ret;
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.report.Close();
            windowList.Remove(this);
        }
    }
}