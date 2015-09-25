using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Deployment.Application;
using System.IO;

namespace FbcFoodBank
{
    static class Program
    {
        static string dataDirectory;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                dataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                dataDirectory += @"\" + Application.CompanyName;

                if (MigrateDatabase())
                    AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);
                else
                    return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static bool MigrateDatabase()
        {
            try
            {
                string oldLocation = ApplicationDeployment.CurrentDeployment.DataDirectory + @"\" + Properties.Resources.DatabaseName;
                string newLocation = dataDirectory + @"\" + Properties.Resources.DatabaseName;

                if (!Directory.Exists(dataDirectory))
                    Directory.CreateDirectory(dataDirectory);
                if (!File.Exists(newLocation))
                    File.Copy(oldLocation, newLocation);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}