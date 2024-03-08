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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

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
            Console.WriteLine("Install Updates....");

            try
            {
                UpdateSession updateSession = new UpdateSession();
                IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();

                // Search for updates
                updateSearcher.Online = true; // Search online
                ISearchResult searchResult = updateSearcher.Search("IsInstalled=0");

                if (searchResult.Updates.Count == 0)
                {
                    Console.WriteLine("No updates available.");
                    return;
                }

                Console.WriteLine("Found " + searchResult.Updates.Count + " updates.");

                UpdateCollection updatesToDownload = new UpdateCollection();

                // Add updates to the collection to be downloaded
                foreach (IUpdate update in searchResult.Updates)
                {
                    updatesToDownload.Add(update);
                }

                // Create update downloader
                UpdateDownloader updateDownloader = updateSession.CreateUpdateDownloader();
                updateDownloader.Updates = updatesToDownload;

                // Download updates
                Console.WriteLine("Downloading updates...");
                IDownloadResult downloadResult = updateDownloader.Download();

                // Create update installer
                UpdateInstaller updateInstaller = updateSession.CreateUpdateInstaller() as UpdateInstaller;
                updateInstaller.Updates = updatesToDownload;

                // Install updates
                Console.WriteLine("Installing updates...");
                IInstallationResult installationResult = updateInstaller.Install();

                // Check installation result
                if (installationResult.ResultCode == OperationResultCode.orcSucceeded)
                {
                    Console.WriteLine("Updates installed successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to install updates. Error code: " + installationResult.ResultCode);
                    Process.Start("ms-settings:windowsupdate");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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
                string checkedItemText;
                string appPath;
                switch (item.ToString())
                {
                    case "Chrome":
                        checkedItemText = item.ToString();
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\ChromeInstall.exe");
                        Process.Start(appPath);
                        break;
                    case "iTunes":
                        checkedItemText = item.ToString();
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\iTunesInstall.exe");
                        Process.Start(appPath);
                        break;
                    case "Geforce Drivers":
                        checkedItemText = item.ToString();
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\NvidiaInstall.exe");
                        Process.Start(appPath);
                        break;
                    case "Trend":
                        checkedItemText = item.ToString();
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\TrendInstall.exe");
                        Process.Start(appPath);
                        break;
                    default:
                        checkedItemText = item.ToString();
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers", checkedItemText + "Install");
                        silentInstaller.DeployApplications(appPath);
                        break;

                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"installers\MCPR.exe");
            Process.Start(appPath);
        }

        //RemoveUltraViewer
        private void chromebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"UltraViewer\unins000.exe");
                Console.WriteLine(appPath);
                Process.Start(appPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not find uninstaller");
                Process.Start("control", "appwiz.cpl");
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

        //RemoveOneLaunch
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
                string url = "https://chromewebstore.google.com/detail/ublock-origin/cjpalhdlnbpafiamejdnhcphjbkeiagm";

                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe"; // For 64-bit systems

                if (!File.Exists(chromePath))
                {
                    // If Chrome isn't found in the Program Files directory, try Program Files (x86)
                    chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"; // For 32-bit systems
                }

                if (File.Exists(chromePath))
                {
                    Process.Start(chromePath, url);
                }
                else
                {
                    Console.WriteLine("Chrome not found.");
                }
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

        private void bitlockerOff_Click(object sender, EventArgs e)
        {

            try
            {
                // Create a new process
                Process process = new Process();

                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C manage-bde -off C:";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                // Read the command output
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to finish
                process.WaitForExit();

                // Display the command output
                Console.WriteLine("Command output:");
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
