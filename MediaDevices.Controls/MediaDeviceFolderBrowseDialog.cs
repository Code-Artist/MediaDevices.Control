using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaDevices.Controls
{
    public partial class MediaDeviceFolderBrowseDialog : Form
    {
        public string SelectedFolder { get; private set; } = null;

        private MediaDevicesFileExplorer MediaFileExplorer;
        private string DeviceName;
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
            MediaFileExplorer.ConnectionStatusChanged += MediaFileExplorer_ConnectionStatusChanged;
            MediaFileExplorer.ConnectDevice(DeviceName);
            FileExplorer.AttachSource(MediaFileExplorer);
        }

        private void MediaFileExplorer_ConnectionStatusChanged(object sender, EventArgs e)
        {
            if (MediaFileExplorer.IsConnected)
            {
                LbErrorMessage.Visible = false;
                BtOK.Enabled = true;
            }
            else
            {
                BtOK.Enabled = false;
                LbErrorMessage.Visible = true;
                LbErrorMessage.Text = "Device not connected!";
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
