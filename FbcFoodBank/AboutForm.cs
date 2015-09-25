using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace About
{
    public partial class AboutForm : Form
    {
        public AboutForm(string appTitle)
        {
            InitializeComponent();
            this.Text = "About " + appTitle;
            AppLabel.Text = appTitle;
            VersionLabel.Text = "Version " + Application.ProductVersion;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}