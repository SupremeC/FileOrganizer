using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileOrganizer
{
    public partial class Form1 : Form
    {
        private BackgroundWorker bgw = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;
            bgw.DoWork += bgw_DoWork;
            bgw.RunWorkerCompleted += bgw_RunWorkerCompleted;
            bgw.ProgressChanged += bgw_ProgressChanged;

            //Update pattern
            subfolderPatternTextBox_TextChanged(null, null);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            LockUserInterface(false);
        }

        private void LockUserInterface(bool lockdown)
        {
            folderPathTextBox.Enabled = !lockdown;
            folderBrowserButton.Enabled = !lockdown;
            subfolderPatternTextBox.Enabled = !lockdown;
            createdDateRadioButton.Enabled = !lockdown;
            modifiedDateRadioButton.Enabled = !lockdown;
            leave1MFilesradioButton1.Enabled = !lockdown;
            leaveFiles3MRadioButton.Enabled = !lockdown;
            leaveFiles6MradioButton.Enabled = !lockdown;
            CancelButton.Enabled = lockdown;
            RunButton.Enabled = !lockdown;
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            var workerParams = (FileMoveParam)e.Argument;
            try
            {
                var files = Directory.EnumerateFiles(workerParams.FolderToProcess);

                foreach (string currentFile in files)
                {
                    //Check abort flag
                    if (bgw.CancellationPending)
                        break;


                    string subfolder = string.Empty;

                    //Check if file matches date filter
                    FileInfo fi = new FileInfo(currentFile);
                    switch(workerParams.MoveByProperty)
                    {
                        case MoveProperty.DateCreated:
                            if (fi.CreationTime > workerParams.LeaveFilesNewerThen)
                                continue;
                            else
                                subfolder = fi.CreationTime.ToString(workerParams.SubFolderPattern);
                            break;
                        case MoveProperty.DateModified:
                            if (fi.LastWriteTime > workerParams.LeaveFilesNewerThen)
                                continue;
                            else
                                subfolder = fi.LastWriteTime.ToString(workerParams.SubFolderPattern);
                            break;
                        default:
                            throw new Exception("unknown MoveBy property!");
                    }

                    //Create Subfolder
                    Directory.CreateDirectory(Path.Combine(workerParams.FolderToProcess, subfolder));

                    //Move file
                    string newPath = Path.Combine(workerParams.FolderToProcess, subfolder, fi.Name);
                    File.Move(currentFile, newPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    folderPathTextBox.Text = fbd.SelectedPath;
                }
                
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(folderPathTextBox.Text))
            {
                MessageBox.Show("could not find folder");
                return;
            }

            var workerParams = new FileMoveParam();
            workerParams.FolderToProcess = folderPathTextBox.Text.Trim();
            workerParams.SubFolderPattern = subfolderPatternTextBox.Text.Trim();
            workerParams.MoveByProperty = GetUserMoveSelectionAsEnum();
            workerParams.LeaveFilesNewerThen = GetUserFilterSelectionAsDate();

            LockUserInterface(true);
            bgw.RunWorkerAsync(workerParams);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Abort bgw
            bgw.CancelAsync();

            //Unlock user interface (unlocked when worker exits)
            //LockUserInterface(false);
        }
        private void subfolderPatternTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                patternpreviewLabel.Text = "\"" + DateTime.Now.ToString(subfolderPatternTextBox.Text) + "\"";
                patternpreviewLabel.ForeColor = Color.DarkGray;
            }
            catch
            {
                patternpreviewLabel.Text = "invalid format";
                patternpreviewLabel.ForeColor = Color.Red;
            }
        }
        private MoveProperty GetUserMoveSelectionAsEnum()
        {
            if (createdDateRadioButton.Checked)
                return MoveProperty.DateCreated;
            else
                return MoveProperty.DateModified;
        }
        private DateTime GetUserFilterSelectionAsDate()
        {
            if (leave1MFilesradioButton1.Checked)
                return DateTime.Now.Subtract(new TimeSpan(30, 0, 0, 0, 0));
            if (leaveFiles3MRadioButton.Checked)
                return DateTime.Now.Subtract(new TimeSpan(90, 0, 0, 0, 0));
            if (leaveFiles6MradioButton.Checked)
                return DateTime.Now.Subtract(new TimeSpan(183, 0, 0, 0, 0));
            if (leaveNoFilesRadioButton.Checked)
                return DateTime.Now.AddDays(1); //Future date. This will match all current files
            else
                throw new Exception("Date filter unknown");
        }
    }
}
