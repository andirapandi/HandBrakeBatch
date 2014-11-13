using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchEncode
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonSourceBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            var res = dlg.ShowDialog();
            if (res.Equals(DialogResult.OK))
            {
                TextBoxSource.Text = dlg.SelectedPath;
                TextBoxTarget.Text = dlg.SelectedPath + "_out";
            }
        }

        private void ButtonBrowseTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            var res = dlg.ShowDialog();
            if (res.Equals(DialogResult.OK))
                TextBoxTarget.Text = dlg.SelectedPath;
        }

        private void ButtonBrowseHandbrake_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select the HandbrakeCLI.exe file from Handbrake program folder.";
            dlg.Filter = "handbrakecli flie (HandBrakeCLI.exe)|HandBrakeCLI.exe|All file (*.*)|*.*";
            var res = dlg.ShowDialog();
            if (res.Equals(DialogResult.OK))
                TextBoxHandBrake.Text = dlg.FileName;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private volatile bool shouldRun = false;
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            shouldRun = !shouldRun;
            ButtonStart.Text = shouldRun ? "Stop" : "Start";
            if (!shouldRun)
                return;
            string sourcePath = TextBoxSource.Text;
            string targetPath = TextBoxTarget.Text;
            string cliPath = TextBoxHandBrake.Text;
            string commandLine = TextBoxCommandLine.Text;
            //RecurseEncode(sourcePath, targetPath, cliPath, commandLine);

            int cnt = RecurseCount(sourcePath, targetPath);

            Task.Factory.StartNew(
                () =>
                    RecurseEncode(sourcePath, targetPath, cliPath, commandLine, cnt)
                );
        }

        int RecurseCount(string sourcePath, string targetPath)
        {
            int cnt = 0;
            RecurseExecute(sourcePath, targetPath,
                (x, y) =>
                {
                    ++cnt;
                    labelStatus.Text = "Count: " + cnt + " Files.";
                }
            );
            return cnt;
        }

        void ExecuteActionInMainLoop(Action a)
        {
            this.BeginInvoke(((MethodInvoker)delegate { a(); }));
        }

        void RecurseEncode(string sourcePath, string targetPath, string cliPath, string commandLine, int cnt)
        {
            int i = 0;
            RecurseExecute(sourcePath, targetPath,
                (x, y) =>
                {
                    ExecuteActionInMainLoop(() =>
                        labelStatus.Text = "Encoded: " + i + "/" + cnt + "* Files."
                        );
                    Encode(x, y, cliPath, commandLine);
                    ExecuteActionInMainLoop(() =>
                    {
                        labelStatus.Text = "Encode: " + ++i + "/" + cnt + " Files.";
                        if (cnt == i)
                            labelStatus.Text = "Encode: " + ++i + "/" + cnt +
                                               " Files. All completed, live long and prosper.";
                    }
                        );

                }
            );
            ExecuteActionInMainLoop(() =>
                ButtonStart.Text = "Start"
     );
        }

        void RecurseExecute(string sourcePath, string targetPath, Action<string, string> a)
        {
            #region process current folder
            foreach (var f in Directory.EnumerateFiles(sourcePath))
            {
                if (!shouldRun)
                    return;
                string inPath = f;
                //if (inPath.EndsWith(".mp4") || inPath.EndsWith(".mkv") || (inPath.EndsWith(".wmv")))
                if (CheckEnding(inPath))
                {
                    //string outPath = targetPath + inPath.Substring(sourcePath.Length);
                    string outPath = Path.Combine(targetPath, Path.GetFileName(inPath));
                    if (checkBoxFFileExtension.Checked)
                    {
                        outPath = ChangeExtensionToGivenOption(outPath);
                    }
                    if (!Directory.Exists(targetPath))
                        Directory.CreateDirectory(targetPath);
                    if (File.Exists(outPath))
                        if (!checkBoxOverwriteTarget.Checked)
                            continue;
                    a(inPath, outPath);
                }
            }
            #endregion
            #region recurse to subfolders if appropriate
            if (checkBoxIncludeSubfolders.Checked)
                foreach (var d in Directory.EnumerateDirectories(sourcePath))
                {
                    if (!shouldRun)
                        return;
                    RecurseExecute(d, constructPath(sourcePath, d, targetPath), a);
                }
            #endregion
        }

        private string ChangeExtensionToGivenOption(string outPath)
        {
            var str = TextBoxCommandLine.Text;
            var index = str.IndexOf("-f ");
            if (index >= 0)
            {
                str = str.Substring(index + 3);
                var index2 = str.IndexOf(" ");
                if (index2 < 0)
                    index2 = str.Length - 1;
                var ending = str.Substring(0, index2);
                outPath = outPath.Substring(0, outPath.Length - Path.GetExtension(outPath).Length) + "." + ending;
            }
            return outPath;
        }

        private bool CheckEnding(string inPath)
        {
            var endings = textBoxFileExtensions.Text.Split(new char[] { ',' });
            foreach (var ending in endings)
                if (inPath.EndsWith(ending))
                    return true;
            return false;
        }

        //void RecurseEncode(string sourcePath, string targetPath, string cliPath, string commandLine)
        //{
        //    foreach (var f in Directory.EnumerateFiles(sourcePath))
        //    {
        //        string inPath = f;
        //        if (inPath.EndsWith(".mp4") || inPath.EndsWith(".mkv") || (inPath.EndsWith(".wmv")))
        //        {
        //            string outPath = targetPath + inPath.Substring(sourcePath.Length);
        //            if (!Directory.Exists(targetPath))
        //                Directory.CreateDirectory(targetPath);
        //            Encode(inPath, outPath, cliPath, commandLine);
        //        }
        //    }
        //    foreach (var d in Directory.EnumerateDirectories(sourcePath))
        //    {
        //        RecurseEncode(d, constructPath(sourcePath, d, targetPath), cliPath, commandLine);
        //    }
        //}

        void Encode(string inPath, string outPath, string cliPath, string commandLine)
        {
            string newCommandLine = commandLine + " -i \"" + inPath + "\" -o \"" + outPath + "\"";
            ProcessStartInfo psi = new ProcessStartInfo(cliPath, newCommandLine);
            psi.WindowStyle = ProcessWindowStyle.Minimized;
            //Process p = new Process();
            //p.StartInfo.FileName = cliPath;
            //p.StartInfo.Arguments = commandLine;
            //p.win

            Process p = Process.Start(psi);
            p.PriorityClass = ProcessPriorityClass.BelowNormal;

            //var p = Process.Start(cliPath, commandLine + " -i \"" + inPath + "\" -o \"" + outPath + "\"");
            //var p = Process.Start("\"C:\Tool\Handbrake\HandBrakeCLI.exe\" -i \"C:\Users\areiff\Desktop\Coursera Udacity\How to Build a Startup (Udacity)\Lecture 0 Before You Get Started\ep245 unit0 02 l business model canvas introduction.mp4\" -t 1 -c 1 -o \"C:\Users\areiff\Desktop\Ep245 Unit0 02 L Business Model Canvas Introduction-1.mp4\"  -f mp4 -w 1024 --loose-anamorphic  -e x264 -q 20 --vfr  -a 1 -E faac -B 128 -6 dpl2 -R Auto -D 0 --gain=0 --audio-copy-mask none --audio-fallback ffac3 -x ref=1:weightp=1:subq=2:rc-lookahead=10:trellis=0:8x8dct=0 --verbose=1");
            while (shouldRun)
                p.WaitForExit(100);
            //p.WaitForExit();
        }

        string constructPath(string inPathParent, string inPath, string outPathParent)
        {
            return outPathParent + inPath.Substring(inPathParent.Length);
        }
    }
}
