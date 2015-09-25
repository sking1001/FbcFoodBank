using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace FbcFoodBank
{
    public partial class CreateReport : Form
    {
        public string DateRange
        {
            get { return this.dateRangeListBox.SelectedItem.ToString(); }
        }

        public DateTime StartDate
        {
            get { return this.startDateTimePicker.Value; }
        }

        public DateTime EndDate
        {
            get { return endDateTimePicker.Value; }
        }

        public bool SortByName
        {
            get { return this.sortByNameCheckBox.Checked; }
        }

        public bool IncludeInactive
        {
            get { return this.inactiveCheckBox.Checked; }
        }

        public CreateReport()
        {
            InitializeComponent();
            this.dateRangeListBox.SelectedItem = "Current Month";
        }

        void DoCreateReport()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateRangeListBox_DoubleClick(object sender, EventArgs e)
        {
            DoCreateReport();
        }

        private void createReportButton_Click(object sender, EventArgs e)
        {
            DoCreateReport();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime QuarterFromMonth(DateTime month)
        {
            DateTime ret = new DateTime(month.Year, month.Month, 1);

            switch (month.Month)
            {
                case 1:
                case 2:
                case 3:
                    ret = new DateTime(ret.Year, 1, 1);
                    break;
                case 4:
                case 5:
                case 6:
                    ret = new DateTime(ret.Year, 4, 1);
                    break;
                case 7:
                case 8:
                case 9:
                    ret = new DateTime(ret.Year, 7, 1);
                    break;
                case 10:
                case 11:
                case 12:
                    ret = new DateTime(ret.Year, 10, 1);
                    break;
            }

            return ret;
        }

        private void SetDateTimePickers()
        {
            Calendar calender = CultureInfo.InvariantCulture.Calendar;

            DateTime now = DateTime.Now;
            DateTime currentMonthBegin = new DateTime(now.Year, now.Month, 1);
            DateTime currentMonthEnd = new DateTime(now.Year, now.Month, calender.GetDaysInMonth(now.Year, now.Month));
            DateTime lastMonth = calender.AddMonths(now, -1);
            DateTime lastMonthBegin = new DateTime(lastMonth.Year, lastMonth.Month, 1);
            DateTime lastMonthEnd = new DateTime(lastMonth.Year, lastMonth.Month, calender.GetDaysInMonth(lastMonth.Year, lastMonth.Month));
            DateTime currentQuarterBegin = this.QuarterFromMonth(now);
            DateTime currentQuarterEnd = calender.AddMonths(currentQuarterBegin, 2);
            currentQuarterEnd = new DateTime(currentQuarterEnd.Year, currentQuarterEnd.Month, calender.GetDaysInMonth(currentQuarterEnd.Year, currentQuarterEnd.Month));
            DateTime lastQuarterBegin = calender.AddMonths(currentQuarterBegin, -3);
            DateTime lastQuarterEnd = calender.AddMonths(lastQuarterBegin, 2);
            lastQuarterEnd = new DateTime(lastQuarterEnd.Year, lastQuarterEnd.Month, calender.GetDaysInMonth(lastQuarterEnd.Year, lastQuarterEnd.Month));
            DateTime currentYearBegin = new DateTime(now.Year, 1, 1);
            DateTime currentYearEnd = new DateTime(now.Year, 12, 31);
            DateTime lastYearBegin = new DateTime(now.Year - 1, 1, 1);
            DateTime lastYearEnd = new DateTime(now.Year - 1, 12, 31);

            switch (this.dateRangeListBox.SelectedItem.ToString())
            {
                case "Current Month":
                    this.startDateTimePicker.Value = currentMonthBegin;
                    this.endDateTimePicker.Value = currentMonthEnd;
                    break;

                case "Current Quarter":
                    this.startDateTimePicker.Value = currentQuarterBegin;
                    this.endDateTimePicker.Value = currentQuarterEnd;
                    break;

                case "Current Year":
                    this.startDateTimePicker.Value = currentYearBegin;
                    this.endDateTimePicker.Value = currentYearEnd;
                    break;

                case "Year-to-date":
                    this.startDateTimePicker.Value = currentYearBegin;
                    this.endDateTimePicker.Value = now;
                    break;

                case "Last Month":
                    this.startDateTimePicker.Value = lastMonthBegin;
                    this.endDateTimePicker.Value = lastMonthEnd;
                    break;

                case "Last Quarter":
                    this.startDateTimePicker.Value = lastQuarterBegin;
                    this.endDateTimePicker.Value = lastQuarterEnd;
                    break;

                case "Last Year":
                    this.startDateTimePicker.Value = lastYearBegin;
                    this.endDateTimePicker.Value = lastYearEnd;
                    break;

                case "Last Year-to-date":
                    this.startDateTimePicker.Value = lastYearBegin;
                    this.endDateTimePicker.Value = now;
                    break;
            }

            if (this.dateRangeListBox.SelectedItem.ToString() == "All Dates")
            {
                this.startDateTimePicker.Format = DateTimePickerFormat.Custom;
                this.endDateTimePicker.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                this.startDateTimePicker.Format = DateTimePickerFormat.Long;
                this.endDateTimePicker.Format = DateTimePickerFormat.Long;
            }

            if (this.dateRangeListBox.SelectedItem.ToString() == "Custom")
            {
                this.startDateTimePicker.Enabled = true;
                this.endDateTimePicker.Enabled = true;
            }
            else
            {
                this.startDateTimePicker.Enabled = false;
                this.endDateTimePicker.Enabled = false;
            }
        }

        private void dateRangeListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.SetDateTimePickers();
        }
    }
}