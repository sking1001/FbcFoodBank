using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FbcFoodBank
{
    public partial class LoadingReport : Form
    {
        public LoadingReport()
        {
            InitializeComponent();
            this.Text = "    " + Properties.Resources.AppTitle;
        }
    }
}