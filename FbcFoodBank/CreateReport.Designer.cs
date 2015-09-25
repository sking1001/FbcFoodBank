namespace FbcFoodBank
{
    partial class CreateReport
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
            this.createReportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dateRangeListBox = new System.Windows.Forms.ListBox();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.sortByNameCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.dateRangeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createReportButton
            // 
            this.createReportButton.AutoSize = true;
            this.createReportButton.Location = new System.Drawing.Point(299, 189);
            this.createReportButton.Name = "createReportButton";
            this.createReportButton.Size = new System.Drawing.Size(83, 23);
            this.createReportButton.TabIndex = 3;
            this.createReportButton.Text = "Create Report";
            this.createReportButton.UseVisualStyleBackColor = true;
            this.createReportButton.Click += new System.EventHandler(this.createReportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(299, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // dateRangeListBox
            // 
            this.dateRangeListBox.FormattingEnabled = true;
            this.dateRangeListBox.Items.AddRange(new object[] {
            "Current Month",
            "Current Quarter",
            "Current Year",
            "Year-to-date",
            "Last Month",
            "Last Quarter",
            "Last Year",
            "Last Year-to-date",
            "All Dates",
            "Custom"});
            this.dateRangeListBox.Location = new System.Drawing.Point(6, 19);
            this.dateRangeListBox.Name = "dateRangeListBox";
            this.dateRangeListBox.Size = new System.Drawing.Size(120, 134);
            this.dateRangeListBox.TabIndex = 0;
            this.dateRangeListBox.DoubleClick += new System.EventHandler(this.dateRangeListBox_DoubleClick);
            this.dateRangeListBox.SelectedValueChanged += new System.EventHandler(this.dateRangeListBox_SelectedValueChanged);
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(12, 212);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(147, 17);
            this.inactiveCheckBox.TabIndex = 2;
            this.inactiveCheckBox.Text = "Include Inactive Contacts";
            this.inactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortByNameCheckBox
            // 
            this.sortByNameCheckBox.AutoSize = true;
            this.sortByNameCheckBox.Location = new System.Drawing.Point(12, 189);
            this.sortByNameCheckBox.Name = "sortByNameCheckBox";
            this.sortByNameCheckBox.Size = new System.Drawing.Size(90, 17);
            this.sortByNameCheckBox.TabIndex = 1;
            this.sortByNameCheckBox.Text = "Sort by Name";
            this.sortByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = " ";
            this.startDateTimePicker.Location = new System.Drawing.Point(135, 35);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 2;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CustomFormat = " ";
            this.endDateTimePicker.Location = new System.Drawing.Point(135, 90);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 4;
            // 
            // dateRangeGroupBox
            // 
            this.dateRangeGroupBox.Controls.Add(this.endDateTimePicker);
            this.dateRangeGroupBox.Controls.Add(this.dateRangeListBox);
            this.dateRangeGroupBox.Controls.Add(this.label2);
            this.dateRangeGroupBox.Controls.Add(this.startDateTimePicker);
            this.dateRangeGroupBox.Controls.Add(this.label1);
            this.dateRangeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.dateRangeGroupBox.Name = "dateRangeGroupBox";
            this.dateRangeGroupBox.Size = new System.Drawing.Size(370, 165);
            this.dateRangeGroupBox.TabIndex = 0;
            this.dateRangeGroupBox.TabStop = false;
            this.dateRangeGroupBox.Text = "Specify a Date Range:";
            // 
            // CreateReport
            // 
            this.AcceptButton = this.createReportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(394, 253);
            this.Controls.Add(this.sortByNameCheckBox);
            this.Controls.Add(this.inactiveCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createReportButton);
            this.Controls.Add(this.dateRangeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Report";
            this.dateRangeGroupBox.ResumeLayout(false);
            this.dateRangeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createReportButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox dateRangeListBox;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.CheckBox sortByNameCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.GroupBox dateRangeGroupBox;
    }
}