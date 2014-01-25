using System;
using System.Diagnostics;
using System.Windows.Forms;
using TallyJCore.FolderSelector;
using TallyJCore.Properties;

namespace TallyJCore
{
    public partial class MainForm : Form
    {
        private readonly Main _main;

        public MainForm()
        {
            InitializeComponent();

            _main = new Main(this);

            ReloadSavedValues();
        }

        private void ReloadSavedValues()
        {
            txtPort.Value = Settings.Default.Port;
            txtFolder.Text = Settings.Default.WebFolder;
            txtConnectionString.Text = Settings.Default.Connection;

            _main.SetFolder(txtFolder.Text);
            _main.SetPort((int) txtPort.Value);
            _main.SetConnection(txtConnectionString.Text);


            if (Settings.Default.Size.Width > 0)
            {
                Size = Settings.Default.Size;
                Location = Settings.Default.Location;
            }

            SetButtonStates(Status.Stopped);
        }

        public void SetUrl(string url)
        {
            txtURL.Text = url;
            qrCodeImgControl1.Text = url;

            lblQrCode.Visible =
                qrCodeImgControl1.Visible =
                    !string.IsNullOrWhiteSpace(url);
        }

        public void ShowStatusText(string text)
        {
            lblStatus.Text = text;
        }

        public void SetButtonStates(Status status)
        {
            switch (status)
            {
                case Status.Stopped:

                    txtFolder.Enabled =
                        txtPort.Enabled =
                            txtConnectionString.Enabled =
                                btnStart.Enabled =
                                    startServerToolStripMenuItem1.Enabled =
                                        btnSelectFolder.Enabled =
                                            true;

                    btnView.Enabled =
                        btnCopyToClipboard.Enabled =
                            viewInBrowserToolStripMenuItem1.Enabled =
                                btnStop.Enabled =
                                    stopServerToolStripMenuItem1.Enabled =
                                        false;

                    break;

                case Status.Running:

                    txtFolder.Enabled =
                        txtPort.Enabled =
                            txtConnectionString.Enabled = btnStart.Enabled =
                                startServerToolStripMenuItem1.Enabled =
                                    btnSelectFolder.Enabled =
                                        false;

                    btnView.Enabled =
                        btnCopyToClipboard.Enabled =
                            viewInBrowserToolStripMenuItem1.Enabled =
                                btnStop.Enabled =
                                    stopServerToolStripMenuItem1.Enabled =
                                        true;

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _main.ShowAbout();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderSelectDialog
            {
                InitialDirectory = txtFolder.Text,
                Title = "Select the folder containing the web site files"
            };

            if (dialog.ShowDialog(IntPtr.Zero))
            {
                txtFolder.Text = Settings.Default.WebFolder = dialog.SelectedFolder;
                Settings.Default.Save();

                _main.SetFolder(txtFolder.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.WebFolder = txtFolder.Text;
            Settings.Default.Save();

            _main.SetFolder(txtFolder.Text);
        }


        private void txtConnectionString_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.Connection = txtConnectionString.Text;
            Settings.Default.Save();

            _main.SetConnection(txtConnectionString.Text);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _main.StartServer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _main.StopServer();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                return;
            }
            Process.Start(txtURL.Text);
        }

        private void startServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _main.StartServer();
        }

        private void stopServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _main.StopServer();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _main.ExitProgram();
        }

        private void copyURLToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _main.CopyUrlToClipboard();
        }

        private void viewInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnView_Click(sender, e);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var port = (int) txtPort.Value;
            _main.SetPort(port);
            Settings.Default.Port = port;
            Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // why??
            // _main.ExitProgram();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            _main.CopyUrlToClipboard();
        }

        private void startServerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _main.StartServer();
        }

        private void stopServerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _main.StopServer();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _main.ExitProgram();
        }

        private void viewInBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnView_Click(null, null);
        }

        private void copyURLToClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _main.CopyUrlToClipboard();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Settings.Default.Size = Size;
            Settings.Default.Location = Location;
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          txtConnectionString.Text = _main.GetCurrentMainConnection();
        }
    }
}