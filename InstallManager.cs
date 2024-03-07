using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Management.Automation;
using System.Threading;
using System.Windows.Forms;

namespace SilentInstallation
{
    class InstallManager
    {

        public void ProcessFolder()
        {
            string SOURCEFOLDERPATH = Path.Combine(Environment.CurrentDirectory, @"installers");

            if (Directory.Exists(SOURCEFOLDERPATH))
            {
                Console.WriteLine("Directory exists at: {0}", SOURCEFOLDERPATH);
                if (Directory.GetFiles(SOURCEFOLDERPATH, "*.exe").Length > 0)
                {
                    int count = Directory.GetFiles(SOURCEFOLDERPATH, "*.exe").Length;
                    string[] files = Directory.GetFiles(SOURCEFOLDERPATH, "*.exe");

                    foreach (var file in files)
                    {
                        var fileName = System.IO.Path.GetFileName(file);
                        var fileNameWithPath = SOURCEFOLDERPATH + "\\" + fileName;
                        Console.WriteLine("File Name: {0}", fileName);
                        Console.WriteLine("File name with path : {0}", fileNameWithPath);
                        //Deploy application  
                        DeployApplications(fileNameWithPath);
                    }
                }

            }
            else
                Console.WriteLine("Directory does not exist at: {0}", SOURCEFOLDERPATH);

        }


        public void DeployApplications(string executableFilePath)
        {

            PowerShell powerShell = null;
            Console.WriteLine(" ");
            Console.WriteLine("Deploying application...");
            Console.WriteLine(executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    //here “executableFilePath” need to use in place of “  
                    //'C:\\ApplicationRepository\\FileZilla_3.14.1_win64-setup.exe'”  
                    //but I am using the path directly in the script.  
                    powerShell.AddScript("$setup=Start-Process -Wait -FilePath " + executableFilePath + " -ArgumentList '/Silent /Install' -PassThru");  


                    Collection < PSObject > PSOutput = powerShell.Invoke(); foreach (PSObject outputItem in PSOutput)
                    {

                        if (outputItem != null)
                        {

                            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                        }
                    }

                    if (powerShell.Streams.Error.Count > 0)
                    {
                        string temp = powerShell.Streams.Error.First().ToString();
                        Console.WriteLine("Error: {0}", temp);

                    }
                    else
                        Console.WriteLine("Installation has completed successfully.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.InnerException);
                //throw;  
            }
            finally
            {
                if (powerShell != null)
                    powerShell.Dispose();
            }



        }



    }
}
