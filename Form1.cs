using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Linq;

namespace OpenJDKInstaller
{
    public partial class Form1 : Form
    {

        private FileInfo zipFolder = null;
        private string zipName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (files.Length == 1)
            {
                if (files[0].EndsWith(".zip"))
                {
                    zipFolder = new FileInfo(files[0]);
                    tfZipFolderPath.Text = zipFolder.FullName;
                }
                else
                {
                    MessageBox.Show("Not a ZIPFOLDER!", "No zipfolder here...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Only one file is accepted!", "Too many files!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
            {
                tfInstallationPath.Text = fbd.SelectedPath;
            }
            
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if(!tfInstallationPath.Text.Equals("") && !tfZipFolderPath.Equals(""))
            {
                try
                {
                    ZipFile.ExtractToDirectory(tfZipFolderPath.Text, tfInstallationPath.Text);
                    var zip = ZipFile.OpenRead(tfZipFolderPath.Text);
                    string name = zip.Entries.ElementAt(0).ToString();
                    
                    MessageBox.Show("JDK was installed successfully!");
                    
                    string envPath = Environment.GetEnvironmentVariable("path", EnvironmentVariableTarget.Machine);
                    if(!envPath.Contains(tfInstallationPath.Text + @"\" + name.Replace('/', '\\') + @"bin"))
                    {
                        Environment.SetEnvironmentVariable("path", tfInstallationPath.Text + @"\" + name.Replace('/', '\\') + @"bin;" + envPath, EnvironmentVariableTarget.Machine);
                    }
                    
                    MessageBox.Show("The Environmentvariables were set successfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went totally wrong here!\nBe sure, you started this app in administrator mode!");
                }
                
            }
            else
            {
                MessageBox.Show("All textfields have to be filled!", "Empty fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectOpenJDK_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(fd.FileName))
            {
                if (fd.FileName.EndsWith(".zip"))
                {
                    tfZipFolderPath.Text = fd.FileName;
                }
                else
                {
                    MessageBox.Show("This is not a ZIPFOLDER!", "No zipfolder!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = new System.Drawing.Icon(@"src\icon.ico");
        }
    }
}
