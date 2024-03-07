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
using Microsoft.Win32;

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

        public void UpdateConsoleOutput(string text)
        {
            if (textBoxConsoleOutput.InvokeRequired)
            {
                textBoxConsoleOutput.Invoke(new Action<string>(UpdateConsoleOutput), text);
            }
            else
            {
                textBoxConsoleOutput.AppendText(text + Environment.NewLine);
            }
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

                        // Specify the URI for Windows Update settings
                        string windowsUpdateUri = "ms-settings:windowsupdate";

                        // Use Process.Start to launch the URI
                        Process.Start(windowsUpdateUri);
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
                if (item.ToString() != "Chrome")
                {
                    string checkedItemText = item.ToString();
                    string appPath = Path.Combine(Environment.CurrentDirectory, @"installers", checkedItemText, "Install");
                    silentInstaller.DeployApplications(appPath);
                }
                else
                {
                    string checkedItemText = item.ToString();
                    string appPath = Path.Combine(Environment.CurrentDirectory, @"installers\ChromeInstall.exe");
                    Process.Start(appPath);

                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"installers\MCPR.exe");
            Process.Start(appPath);
        }

        private void chromebtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the path to Chrome's executable
                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

                // Set Chrome as the default browser
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice", "Progid", "ChromeHTML", RegistryValueKind.String);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice", "Progid", "ChromeHTML", RegistryValueKind.String);

                // Optional: Set Chrome's path as the default browser
                Registry.SetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", "", "\"" + chromePath + "\" -- \"%1\"");

                Console.WriteLine("Google Chrome set as the default browser.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void gsbackup_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the path to the user's desktop folder
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Combine the desktop path with the folder name
                string backupFolderPath = Path.Combine(desktopPath, "GSBackup");

                // Check if the folder already exists
                if (!Directory.Exists(backupFolderPath))
                {
                    // Create the folder
                    Directory.CreateDirectory(backupFolderPath);

                    Console.WriteLine("GSBackup folder created successfully on the desktop.");
                }
                else
                {
                    Console.WriteLine("GSBackup folder already exists on the desktop.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //Furmark

        private void button2_Click_2(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\Furmark");
            Process.Start(appPath);
        }

        private void sfcscan_Click(object sender, EventArgs e)
        {
            try
            {
                string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Local\OneLaunch\unins000.exe");
                Console.WriteLine(appPath);
                Process.Start(appPath);
            } catch (Exception ex)
            {
                Console.WriteLine("Could not find uninstaller");
                Process.Start("control", "appwiz.cpl");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the URL you want to open in Chrome
                string url = "https://chromewebstore.google.com/detail/ublock-origin/cjpalhdlnbpafiamejdnhcphjbkeiagm";

                // Specify the path to the Chrome executable
                string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; // Adjust the path as needed

                // Start Chrome process with the URL as an argument
                Process.Start(chromePath, url);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("control", "appwiz.cpl");
        }

        private void diskmark_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\CrystalDiskMark");
            Process.Start(appPath);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cpuz_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\CPU-Z");
            Process.Start(appPath);
        }

        private void DDU_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\Display Driver Uninstaller");
            Process.Start(appPath);
        }
    }
}
