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

        private async void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Checking for and installing updates...");

            try
            {
                await Task.Run(() => CheckAndInstallUpdates());
                Console.WriteLine("Update process completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void CheckAndInstallUpdates()
        {
            try
            {
                UpdateSession updateSession = new UpdateSession();
                IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();

                Console.WriteLine("Searching for updates...");
                updateSearcher.Online = true; // Enable online search
                ISearchResult searchResult = updateSearcher.Search("IsInstalled=0");

                if (searchResult.Updates.Count == 0)
                {
                    Console.WriteLine("No updates available.");
                    return;
                }

                Console.WriteLine($"Found {searchResult.Updates.Count} updates.");

                // Prepare updates to download
                UpdateCollection updatesToDownload = new UpdateCollection();
                foreach (IUpdate update in searchResult.Updates)
                {
                    updatesToDownload.Add(update);
                    Console.WriteLine($"Queued update: {update.Title}");
                }

                // Create update downloader
                UpdateDownloader updateDownloader = updateSession.CreateUpdateDownloader();
                updateDownloader.Updates = updatesToDownload;

                // Download updates
                Console.WriteLine("Starting download...");
                IDownloadResult downloadResult = updateDownloader.Download();

                if (downloadResult.ResultCode != OperationResultCode.orcSucceeded)
                {
                    Console.WriteLine("Download failed. Checking individual updates...");
                    foreach (IUpdate update in updatesToDownload)
                    {
                        if (update.IsDownloaded)
                        {
                            Console.WriteLine($"Update downloaded successfully: {update.Title}");
                        }
                        else
                        {
                            Console.WriteLine($"Update failed to download: {update.Title}");
                        }
                    }
                    return;
                }

                Console.WriteLine("All updates downloaded successfully.");

                // Install updates
                UpdateInstaller updateInstaller = updateSession.CreateUpdateInstaller() as UpdateInstaller;
                updateInstaller.Updates = updatesToDownload;

                Console.WriteLine("Installing updates...");
                IInstallationResult installationResult = updateInstaller.Install();

                if (installationResult.ResultCode == OperationResultCode.orcSucceeded)
                {
                    Console.WriteLine("Updates installed successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to install updates. Error code: {installationResult.ResultCode}");
                    Process.Start("ms-settings:windowsupdate");
                }
            }
            catch (COMException comEx)
            {
                Console.WriteLine($"COM error occurred: {comEx.Message} (HRESULT: {comEx.HResult:X})");
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

        private async void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Installing selected applications...");

            List<string> appsToInstall = applicationsCheckbox.CheckedItems.Cast<string>().ToList();

            // Run the installation process on a background thread
            await Task.Run(() => InstallApplications(appsToInstall));

            Console.WriteLine("Installation process completed.");
        }

        private void InstallApplications(List<string> applications)
        {
            foreach (string appName in applications)
            {
                string appPath;

                switch (appName)
                {
                    case "Chrome":
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\ChromeInstall.exe");
                        break;
                    case "iTunes":
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\iTunesInstall.exe");
                        break;
                    case "Geforce Drivers":
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\NvidiaInstall.exe");
                        break;
                    case "Trend":
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers\TrendInstall.exe");
                        break;
                    default:
                        appPath = Path.Combine(Environment.CurrentDirectory, @"installers", appName + "Install");
                        break;
                }

                try
                {
                    Console.WriteLine($"Installing {appName}...");
                    Process.Start(appPath)?.WaitForExit(); // Wait for the process to complete
                    Console.WriteLine($"{appName} installed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to install {appName}. Error: {ex.Message}");
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
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\FurMark\runFurmark");
            Console.WriteLine("Opening FurMark");
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
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\CrystalDiskMark\DiskMark64");
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
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\CPUZ\CPUZ");
            Process.Start(appPath);
        }

        private void DDU_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Environment.CurrentDirectory, @"utilities\DDU\DDU");
            Process.Start(appPath);
        }

        private async void bitlockerOff_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Disabling BitLocker...");
                string output = await Task.Run(() => DisableBitLocker());
                Console.WriteLine("Command output:");
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private string DisableBitLocker()
        {
            try
            {
                // Create a new process
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C manage-bde -off C:";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();

                    // Read the command output
                    string output = process.StandardOutput.ReadToEnd();

                    // Wait for the process to finish
                    process.WaitForExit();

                    return output;
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine("Checking if processes are running...");

                // List of processes to check
                List<string> processesToCheck = new List<string> { "anydesk", "support.client" };

                // Check processes on a background thread
                var results = await Task.Run(() => CheckProcesses(processesToCheck));

                // Display results
                for (int i = 0; i < processesToCheck.Count; i++)
                {
                    string status = results[i] ? "Running" : "Not Running";
                    Console.WriteLine($"{processesToCheck[i]}: {status}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private List<bool> CheckProcesses(List<string> processNames)
        {
            List<bool> results = new();
            foreach (string name in processNames)
            {
                try
                {
                    // Check if the process is running
                    bool isRunning = Process.GetProcessesByName(name).Length > 0;
                    results.Add(isRunning);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking process '{name}': {ex.Message}");
                    results.Add(false); // Assume not running in case of error
                }
            }
            return results;
        }


    }
}
