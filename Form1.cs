using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUApiLib;
using SilentInstallation;
using System.IO;
using System.Diagnostics;

namespace WindowsTotalBuildAssistant
{
    public partial class Form1 : Form
    {
        TextBoxStreamWriter writer;
        InstallManager silentInstaller;

        public Form1()
        {
            InitializeComponent();
            writer = new TextBoxStreamWriter(textBoxConsoleOutput);
            silentInstaller = new InstallManager();
            Console.SetOut(writer);

            this.Text = "WTBA?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("WTBA?");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You think they are hiding in the Windows updates?");
            Console.WriteLine("(BTW this shit doesn't work yet)");


            // Create a new instance of the UpdateSession
            UpdateSession updateSession = new UpdateSession();

            // Create a new instance of the UpdateSearcher
            IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();

            try
            {
                Console.WriteLine("Searching for available updates...");

                // Search for available updates
                ISearchResult searchResult = updateSearcher.Search("IsInstalled=0");

                // Check if updates are available
                if (searchResult.Updates.Count > 0)
                {
                    Console.WriteLine("Updates found. Starting installation...");

                    // Iterate through the updates and print their names
                    foreach (IUpdate update in searchResult.Updates)
                    {
                        Console.WriteLine("- " + update.Title);
                    }

                    // Create a new instance of the UpdateInstaller
                    //IUpdateInstaller updateInstaller = updateSession.CreateUpdateInstaller();
                    IUpdateInstaller2 updateInstaller = new UpdateInstaller();


                    // Add all updates to the installer
                    updateInstaller.Updates = searchResult.Updates;

                    // Perform the installation
                    IInstallationResult installationResult = updateInstaller.Install();

                    // Check the installation result
                    if (installationResult.ResultCode == OperationResultCode.orcSucceeded)
                    {
                        Console.WriteLine("Updates installed successfully.");
                    }
                    else
                    {
                        Console.WriteLine($"Update installation failed. Result code: {installationResult.ResultCode}");
                    }
                }
                else
                {
                    Console.WriteLine("No updates available.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.WriteLine(e.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing selected applications...");

            foreach (object item in applicationsCheckbox.CheckedItems)
            {
                string checkedItemText = item.ToString();
                Console.WriteLine("Checked item: {0}", checkedItemText);

            }

            foreach (object item in applicationsCheckbox.CheckedItems)
            {
                string checkedItemText = item.ToString();
                string appPath = Path.Combine(Environment.CurrentDirectory, @"installers", checkedItemText);
                silentInstaller.DeployApplications(appPath);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"installers\MCPR.exe");
            Process.Start(appPath);
        }
    }
}
