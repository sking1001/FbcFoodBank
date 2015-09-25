namespace FbcFoodBank
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label adults_in_HomeLabel;
            System.Windows.Forms.Label children_in_HomeLabel;
            System.Windows.Forms.Label adult_s_NamesLabel;
            System.Windows.Forms.Label children_s_NamesLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label state_ZipLabel;
            System.Windows.Forms.Label prayer_RequestLabel;
            System.Windows.Forms.Label special_NeedsLabel;
            System.Windows.Forms.Label inactiveLabel;
            System.Windows.Forms.Label deceasedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fbcFoodBankDataSet = new FbcFoodBank.FbcFoodBankDataSet();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactsTableAdapter = new FbcFoodBank.FbcFoodBankDataSetTableAdapters.ContactsTableAdapter();
            this.contactsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nameSearch = new System.Windows.Forms.ToolStripTextBox();
            this.addVisitNowButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showHideInactiveButton = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.adult_s_NamesTextBox = new System.Windows.Forms.TextBox();
            this.children_s_NamesTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.state_ZipTextBox = new System.Windows.Forms.TextBox();
            this.prayer_RequestTextBox = new System.Windows.Forms.TextBox();
            this.special_NeedsTextBox = new System.Windows.Forms.TextBox();
            this.adults_in_HomeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.children_in_HomeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.visitsTableAdapter = new FbcFoodBank.FbcFoodBankDataSetTableAdapters.VisitsTableAdapter();
            this.visitsDataGridView = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new CalendarDataGridView.CalendarColumn();
            this.adultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVisitNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.deceasedCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new ErrorProviderFixed.ErrorProviderFixed(this.components);
            nameLabel = new System.Windows.Forms.Label();
            adults_in_HomeLabel = new System.Windows.Forms.Label();
            children_in_HomeLabel = new System.Windows.Forms.Label();
            adult_s_NamesLabel = new System.Windows.Forms.Label();
            children_s_NamesLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            state_ZipLabel = new System.Windows.Forms.Label();
            prayer_RequestLabel = new System.Windows.Forms.Label();
            special_NeedsLabel = new System.Windows.Forms.Label();
            inactiveLabel = new System.Windows.Forms.Label();
            deceasedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fbcFoodBankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingNavigator)).BeginInit();
            this.contactsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adults_in_HomeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_in_HomeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).BeginInit();
            this.visitsDataGridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(12, 52);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // adults_in_HomeLabel
            // 
            adults_in_HomeLabel.AutoSize = true;
            adults_in_HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adults_in_HomeLabel.Location = new System.Drawing.Point(12, 83);
            adults_in_HomeLabel.Name = "adults_in_HomeLabel";
            adults_in_HomeLabel.Size = new System.Drawing.Size(121, 20);
            adults_in_HomeLabel.TabIndex = 4;
            adults_in_HomeLabel.Text = "Adults in Home:";
            // 
            // children_in_HomeLabel
            // 
            children_in_HomeLabel.AutoSize = true;
            children_in_HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            children_in_HomeLabel.Location = new System.Drawing.Point(10, 115);
            children_in_HomeLabel.Name = "children_in_HomeLabel";
            children_in_HomeLabel.Size = new System.Drawing.Size(134, 20);
            children_in_HomeLabel.TabIndex = 6;
            children_in_HomeLabel.Text = "Children in Home:";
            // 
            // adult_s_NamesLabel
            // 
            adult_s_NamesLabel.AutoSize = true;
            adult_s_NamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adult_s_NamesLabel.Location = new System.Drawing.Point(12, 148);
            adult_s_NamesLabel.Name = "adult_s_NamesLabel";
            adult_s_NamesLabel.Size = new System.Drawing.Size(115, 20);
            adult_s_NamesLabel.TabIndex = 8;
            adult_s_NamesLabel.Text = "Adults\' Names:";
            // 
            // children_s_NamesLabel
            // 
            children_s_NamesLabel.AutoSize = true;
            children_s_NamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            children_s_NamesLabel.Location = new System.Drawing.Point(12, 274);
            children_s_NamesLabel.Name = "children_s_NamesLabel";
            children_s_NamesLabel.Size = new System.Drawing.Size(136, 20);
            children_s_NamesLabel.TabIndex = 10;
            children_s_NamesLabel.Text = "Children\'s Names:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetLabel.Location = new System.Drawing.Point(12, 400);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(57, 20);
            streetLabel.TabIndex = 12;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(12, 432);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(39, 20);
            cityLabel.TabIndex = 14;
            cityLabel.Text = "City:";
            // 
            // state_ZipLabel
            // 
            state_ZipLabel.AutoSize = true;
            state_ZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            state_ZipLabel.Location = new System.Drawing.Point(12, 464);
            state_ZipLabel.Name = "state_ZipLabel";
            state_ZipLabel.Size = new System.Drawing.Size(78, 20);
            state_ZipLabel.TabIndex = 16;
            state_ZipLabel.Text = "State/Zip:";
            // 
            // prayer_RequestLabel
            // 
            prayer_RequestLabel.AutoSize = true;
            prayer_RequestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prayer_RequestLabel.Location = new System.Drawing.Point(408, 52);
            prayer_RequestLabel.Name = "prayer_RequestLabel";
            prayer_RequestLabel.Size = new System.Drawing.Size(123, 20);
            prayer_RequestLabel.TabIndex = 22;
            prayer_RequestLabel.Text = "Prayer Request:";
            // 
            // special_NeedsLabel
            // 
            special_NeedsLabel.AutoSize = true;
            special_NeedsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            special_NeedsLabel.Location = new System.Drawing.Point(416, 181);
            special_NeedsLabel.Name = "special_NeedsLabel";
            special_NeedsLabel.Size = new System.Drawing.Size(115, 20);
            special_NeedsLabel.TabIndex = 24;
            special_NeedsLabel.Text = "Special Needs:";
            // 
            // inactiveLabel
            // 
            inactiveLabel.AutoSize = true;
            inactiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inactiveLabel.Location = new System.Drawing.Point(12, 506);
            inactiveLabel.Name = "inactiveLabel";
            inactiveLabel.Size = new System.Drawing.Size(68, 20);
            inactiveLabel.TabIndex = 18;
            inactiveLabel.Text = "Inactive:";
            // 
            // deceasedLabel
            // 
            deceasedLabel.AutoSize = true;
            deceasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deceasedLabel.Location = new System.Drawing.Point(148, 506);
            deceasedLabel.Name = "deceasedLabel";
            deceasedLabel.Size = new System.Drawing.Size(86, 20);
            deceasedLabel.TabIndex = 20;
            deceasedLabel.Text = "Deceased:";
            // 
            // fbcFoodBankDataSet
            // 
            this.fbcFoodBankDataSet.DataSetName = "FbcFoodBankDataSet";
            this.fbcFoodBankDataSet.EnforceConstraints = false;
            this.fbcFoodBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.fbcFoodBankDataSet;
            this.contactsBindingSource.Filter = "Inactive=false";
            this.contactsBindingSource.PositionChanged += new System.EventHandler(this.contactsBindingSource_PositionChanged);
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactsBindingNavigator
            // 
            this.contactsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactsBindingNavigator.BindingSource = this.contactsBindingSource;
            this.contactsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactsBindingNavigator.DeleteItem = null;
            this.contactsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.contactsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.nameSearch,
            this.addVisitNowButton,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsBindingNavigatorSaveItem,
            this.toolStripSeparator3,
            this.showHideInactiveButton});
            this.contactsBindingNavigator.Location = new System.Drawing.Point(0, 24);
            this.contactsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactsBindingNavigator.Name = "contactsBindingNavigator";
            this.contactsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactsBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.contactsBindingNavigator.TabIndex = 1;
            this.contactsBindingNavigator.TabStop = true;
            this.contactsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.AutoToolTip = false;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "New Contact";
            this.bindingNavigatorAddNewItem.ToolTipText = "New Contact";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(74, 22);
            this.toolStripLabel1.Text = "Name Search:";
            // 
            // nameSearch
            // 
            this.nameSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(150, 25);
            this.nameSearch.TextChanged += new System.EventHandler(this.nameSearch_TextChanged);
            // 
            // addVisitNowButton
            // 
            this.addVisitNowButton.AutoToolTip = false;
            this.addVisitNowButton.Image = ((System.Drawing.Image)(resources.GetObject("addVisitNowButton.Image")));
            this.addVisitNowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addVisitNowButton.Name = "addVisitNowButton";
            this.addVisitNowButton.Size = new System.Drawing.Size(92, 22);
            this.addVisitNowButton.Text = "Add Visit &Now";
            this.addVisitNowButton.ToolTipText = "Ctrl+N";
            this.addVisitNowButton.Click += new System.EventHandler(this.addVisitNowButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AutoToolTip = false;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete Contact";
            this.bindingNavigatorDeleteItem.ToolTipText = "Delete Contact";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // contactsBindingNavigatorSaveItem
            // 
            this.contactsBindingNavigatorSaveItem.AutoToolTip = false;
            this.contactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingNavigatorSaveItem.Enabled = false;
            this.contactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingNavigatorSaveItem.Image")));
            this.contactsBindingNavigatorSaveItem.Name = "contactsBindingNavigatorSaveItem";
            this.contactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactsBindingNavigatorSaveItem.Text = "Save Changes";
            this.contactsBindingNavigatorSaveItem.ToolTipText = "Save Changes";
            this.contactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // showHideInactiveButton
            // 
            this.showHideInactiveButton.AutoToolTip = false;
            this.showHideInactiveButton.CheckOnClick = true;
            this.showHideInactiveButton.Image = global::FbcFoodBank.Properties.Resources.active;
            this.showHideInactiveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showHideInactiveButton.Name = "showHideInactiveButton";
            this.showHideInactiveButton.Size = new System.Drawing.Size(82, 22);
            this.showHideInactiveButton.Text = "Only Active";
            this.showHideInactiveButton.Click += new System.EventHandler(this.showHideInactiveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(152, 52);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 26);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // adult_s_NamesTextBox
            // 
            this.adult_s_NamesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Adults\' Names", true));
            this.adult_s_NamesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult_s_NamesTextBox.Location = new System.Drawing.Point(152, 148);
            this.adult_s_NamesTextBox.MaxLength = 250;
            this.adult_s_NamesTextBox.Multiline = true;
            this.adult_s_NamesTextBox.Name = "adult_s_NamesTextBox";
            this.adult_s_NamesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.adult_s_NamesTextBox.Size = new System.Drawing.Size(245, 120);
            this.adult_s_NamesTextBox.TabIndex = 9;
            // 
            // children_s_NamesTextBox
            // 
            this.children_s_NamesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Children\'s Names", true));
            this.children_s_NamesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.children_s_NamesTextBox.Location = new System.Drawing.Point(152, 274);
            this.children_s_NamesTextBox.MaxLength = 250;
            this.children_s_NamesTextBox.Multiline = true;
            this.children_s_NamesTextBox.Name = "children_s_NamesTextBox";
            this.children_s_NamesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.children_s_NamesTextBox.Size = new System.Drawing.Size(245, 120);
            this.children_s_NamesTextBox.TabIndex = 11;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(152, 400);
            this.streetTextBox.MaxLength = 50;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(245, 26);
            this.streetTextBox.TabIndex = 13;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(152, 432);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(245, 26);
            this.cityTextBox.TabIndex = 15;
            // 
            // state_ZipTextBox
            // 
            this.state_ZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "State/Zip", true));
            this.state_ZipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state_ZipTextBox.Location = new System.Drawing.Point(152, 464);
            this.state_ZipTextBox.MaxLength = 50;
            this.state_ZipTextBox.Name = "state_ZipTextBox";
            this.state_ZipTextBox.Size = new System.Drawing.Size(245, 26);
            this.state_ZipTextBox.TabIndex = 17;
            // 
            // prayer_RequestTextBox
            // 
            this.prayer_RequestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Prayer Request", true));
            this.prayer_RequestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prayer_RequestTextBox.Location = new System.Drawing.Point(537, 52);
            this.prayer_RequestTextBox.MaxLength = 250;
            this.prayer_RequestTextBox.Multiline = true;
            this.prayer_RequestTextBox.Name = "prayer_RequestTextBox";
            this.prayer_RequestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.prayer_RequestTextBox.Size = new System.Drawing.Size(245, 120);
            this.prayer_RequestTextBox.TabIndex = 23;
            // 
            // special_NeedsTextBox
            // 
            this.special_NeedsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Special Needs", true));
            this.special_NeedsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.special_NeedsTextBox.Location = new System.Drawing.Point(537, 178);
            this.special_NeedsTextBox.MaxLength = 250;
            this.special_NeedsTextBox.Multiline = true;
            this.special_NeedsTextBox.Name = "special_NeedsTextBox";
            this.special_NeedsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.special_NeedsTextBox.Size = new System.Drawing.Size(245, 120);
            this.special_NeedsTextBox.TabIndex = 25;
            // 
            // adults_in_HomeNumericUpDown
            // 
            this.adults_in_HomeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsBindingSource, "Adults in Home", true));
            this.adults_in_HomeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adults_in_HomeNumericUpDown.Location = new System.Drawing.Point(152, 86);
            this.adults_in_HomeNumericUpDown.Name = "adults_in_HomeNumericUpDown";
            this.adults_in_HomeNumericUpDown.Size = new System.Drawing.Size(245, 26);
            this.adults_in_HomeNumericUpDown.TabIndex = 5;
            // 
            // children_in_HomeNumericUpDown
            // 
            this.children_in_HomeNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsBindingSource, "Children in Home", true));
            this.children_in_HomeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.children_in_HomeNumericUpDown.Location = new System.Drawing.Point(152, 118);
            this.children_in_HomeNumericUpDown.Name = "children_in_HomeNumericUpDown";
            this.children_in_HomeNumericUpDown.Size = new System.Drawing.Size(245, 26);
            this.children_in_HomeNumericUpDown.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Dates Visited:";
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // visitsDataGridView
            // 
            this.visitsDataGridView.AllowUserToAddRows = false;
            this.visitsDataGridView.AllowUserToResizeColumns = false;
            this.visitsDataGridView.AllowUserToResizeRows = false;
            this.visitsDataGridView.AutoGenerateColumns = false;
            this.visitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visitsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.visitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.visitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.adultsDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn});
            this.visitsDataGridView.ContextMenuStrip = this.visitsDataGridViewContextMenuStrip;
            this.visitsDataGridView.DataSource = this.visitsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.visitsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.errorProvider1.SetIconAlignment(this.visitsDataGridView, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.visitsDataGridView.Location = new System.Drawing.Point(537, 304);
            this.visitsDataGridView.Name = "visitsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.visitsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.visitsDataGridView.RowHeadersVisible = false;
            this.visitsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.visitsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitsDataGridView.Size = new System.Drawing.Size(245, 222);
            this.visitsDataGridView.TabIndex = 27;
            this.visitsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.visitsDataGridView_UserDeletingRow);
            this.visitsDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.visitsDataGridView_CellMouseDown);
            this.visitsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitsDataGridView_CellEndEdit);
            this.visitsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.visitsDataGridView_DataError);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // adultsDataGridViewTextBoxColumn
            // 
            this.adultsDataGridViewTextBoxColumn.DataPropertyName = "Adults in Home";
            this.adultsDataGridViewTextBoxColumn.HeaderText = "Adults";
            this.adultsDataGridViewTextBoxColumn.Name = "adultsDataGridViewTextBoxColumn";
            this.adultsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "Children in Home";
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // visitsDataGridViewContextMenuStrip
            // 
            this.visitsDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.visitsDataGridViewContextMenuStrip.Name = "visitsDataGridViewContextMenuStrip";
            this.visitsDataGridViewContextMenuStrip.Size = new System.Drawing.Size(188, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deleteToolStripMenuItem.Text = "Delete Selected Visits";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Reference";
            this.visitsBindingSource.DataSource = this.contactsBindingSource;
            this.visitsBindingSource.Sort = "Date DESC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator,
            this.createReportToolStripMenuItem,
            this.toolStripSeparator2,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToolStripMenuItem.Text = "&Save Changes";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(201, 6);
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createReportToolStripMenuItem.Image")));
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.createReportToolStripMenuItem.Text = "Create &Report...";
            this.createReportToolStripMenuItem.Click += new System.EventHandler(this.createReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.importToolStripMenuItem.Text = "&Import Database";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exportToolStripMenuItem.Text = "&Export Database";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.addVisitNowToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.ToolTipText = "Ctrl+N";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // addVisitNowToolStripMenuItem
            // 
            this.addVisitNowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addVisitNowToolStripMenuItem.Image")));
            this.addVisitNowToolStripMenuItem.Name = "addVisitNowToolStripMenuItem";
            this.addVisitNowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addVisitNowToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addVisitNowToolStripMenuItem.Text = "Add Visit &Now";
            this.addVisitNowToolStripMenuItem.Click += new System.EventHandler(this.addVisitNowToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inactiveContactsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // inactiveContactsToolStripMenuItem
            // 
            this.inactiveContactsToolStripMenuItem.CheckOnClick = true;
            this.inactiveContactsToolStripMenuItem.Name = "inactiveContactsToolStripMenuItem";
            this.inactiveContactsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.inactiveContactsToolStripMenuItem.Text = "&Inactive Contacts";
            this.inactiveContactsToolStripMenuItem.Click += new System.EventHandler(this.inactiveContactsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&About [AppTitle]...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contactsBindingSource, "Inactive", true));
            this.inactiveCheckBox.Location = new System.Drawing.Point(86, 506);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.inactiveCheckBox.TabIndex = 19;
            this.inactiveCheckBox.Click += new System.EventHandler(this.inactiveCheckBox_Click);
            // 
            // deceasedCheckBox
            // 
            this.deceasedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.contactsBindingSource, "Deceased", true));
            this.deceasedCheckBox.Location = new System.Drawing.Point(240, 506);
            this.deceasedCheckBox.Name = "deceasedCheckBox";
            this.deceasedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.deceasedCheckBox.TabIndex = 21;
            this.deceasedCheckBox.Click += new System.EventHandler(this.deceasedCheckBox_Click);
            this.deceasedCheckBox.CheckedChanged += new System.EventHandler(this.deceasedCheckBox_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(794, 538);
            this.Controls.Add(deceasedLabel);
            this.Controls.Add(this.deceasedCheckBox);
            this.Controls.Add(inactiveLabel);
            this.Controls.Add(this.inactiveCheckBox);
            this.Controls.Add(this.visitsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.children_in_HomeNumericUpDown);
            this.Controls.Add(this.adults_in_HomeNumericUpDown);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(adults_in_HomeLabel);
            this.Controls.Add(children_in_HomeLabel);
            this.Controls.Add(adult_s_NamesLabel);
            this.Controls.Add(this.adult_s_NamesTextBox);
            this.Controls.Add(children_s_NamesLabel);
            this.Controls.Add(this.children_s_NamesTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(state_ZipLabel);
            this.Controls.Add(this.state_ZipTextBox);
            this.Controls.Add(prayer_RequestLabel);
            this.Controls.Add(this.prayer_RequestTextBox);
            this.Controls.Add(special_NeedsLabel);
            this.Controls.Add(this.special_NeedsTextBox);
            this.Controls.Add(this.contactsBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[AppTitle]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fbcFoodBankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingNavigator)).EndInit();
            this.contactsBindingNavigator.ResumeLayout(false);
            this.contactsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adults_in_HomeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.children_in_HomeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).EndInit();
            this.visitsDataGridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FbcFoodBankDataSet fbcFoodBankDataSet;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private FbcFoodBank.FbcFoodBankDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private System.Windows.Forms.BindingNavigator contactsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox adult_s_NamesTextBox;
        private System.Windows.Forms.TextBox children_s_NamesTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox state_ZipTextBox;
        private System.Windows.Forms.TextBox prayer_RequestTextBox;
        private System.Windows.Forms.TextBox special_NeedsTextBox;
        private System.Windows.Forms.NumericUpDown adults_in_HomeNumericUpDown;
        private System.Windows.Forms.NumericUpDown children_in_HomeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private FbcFoodBank.FbcFoodBankDataSetTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.DataGridView visitsDataGridView;
        private System.Windows.Forms.ToolStripButton addVisitNowButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nameSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private ErrorProviderFixed.ErrorProviderFixed errorProvider1;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.ToolStripButton showHideInactiveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.CheckBox deceasedCheckBox;
        private System.Windows.Forms.ToolStripMenuItem addVisitNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inactiveContactsToolStripMenuItem;
        private CalendarDataGridView.CalendarColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip visitsDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}


