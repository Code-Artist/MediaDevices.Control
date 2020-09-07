using System;
using System.Linq;
using System.Windows.Forms;

namespace MediaDevices.Controls
{
    /// <summary>
    /// Media Device Select Folder Dialog
    /// </summary>
    public partial class MediaDeviceFolderBrowseDialog : Form
    {
        /// <summary>
        /// Get selected folder path
        /// </summary>
        public string SelectedFolder { get; private set; } = null;

        /// <summary>
        /// Get or set initial directory when browser dialog shown
        /// </summary>
        public string InitialDirectory { get; set; }

        private MediaDevicesFileExplorer MediaFileExplorer;
        private readonly string DeviceName;

        /// <summary>
        /// Create instance of folder browse dialog for selected device based on it's description.
        /// </summary>
        /// <param name="deviceName">Device's description.</param>
        public MediaDeviceFolderBrowseDialog(string deviceName)
        {
            InitializeComponent();
            FileExplorer.MultiSelect = false;
            FileExplorer.ShowFoldersOnly = true;
            BtOK.Enabled = false;
            DeviceName = deviceName;
        }

        private void MediaDeviceFolderBrowseDialog_Shown(object sender, EventArgs e)
        {
            MediaFileExplorer = new MediaDevicesFileExplorer();
            MediaFileExplorer.ConnectDevice(DeviceName);
            FileExplorer.AttachSource(MediaFileExplorer);
            MediaFileExplorer.DeviceConnected += MediaFileExplorer_DeviceConnected;
            MediaFileExplorer.DeviceDisconnected += MediaFileExplorer_DeviceDisconnected;
            Connect();
        }

        private void MediaFileExplorer_DeviceDisconnected(object sender, EventArgs e)
        {
            BtOK.Enabled = false;
            LbErrorMessage.Visible = true;
            LbErrorMessage.Text = "Device not connected!";
        }

        private bool DoOnce = false;

        private void MediaFileExplorer_DeviceConnected(object sender, EventArgs e)
        {
            EventTimer.Enabled = true;
        }

        private void EventTimer_Tick(object sender, EventArgs e)
        {
            EventTimer.Enabled = false;
            Connect();
        }

        private void Connect()
        {
            MediaFileExplorer.Reconnect();
            if (MediaFileExplorer.IsConnected)
            {
                if (!DoOnce)
                {
                    if (!string.IsNullOrEmpty(InitialDirectory))
                        FileExplorer.SetSelectedFolder(InitialDirectory);
                    DoOnce = true;
                }
                LbErrorMessage.Visible = false;
                BtOK.Enabled = true;
            }
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (FileExplorer.SelectedFiles() == null)
            {
                if (string.IsNullOrEmpty(FileExplorer.SelectedFolder))
                {
                    MessageBox.Show("No folder selected!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else SelectedFolder = FileExplorer.SelectedFolder;
            }
            else SelectedFolder = FileExplorer.SelectedFiles().First().Replace("/", "\\");

            SelectedFolder = "This PC\\" + DeviceName + SelectedFolder;
            DialogResult = DialogResult.OK;
        }

    }
}
