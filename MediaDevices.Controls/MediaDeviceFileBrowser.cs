using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MediaDevices.Controls
{
    /// <summary>
    /// Media Device File Browser Control
    /// </summary>
    public partial class MediaDeviceFileBrowser : UserControl
    {
        private readonly MediaDevicesFileExplorer FileExplorer;

        /// <summary>
        /// Displays folders only
        /// </summary>
        [DefaultValue(false)]
        [Description("Display folders only")]
        public bool ShowFolderOnly
        {
            get => DeviceFileExplorer.ShowFoldersOnly;
            set => DeviceFileExplorer.ShowFoldersOnly = value;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public MediaDeviceFileBrowser()
        {
            InitializeComponent();
            BtReconnect.Enabled = false;
            FileExplorer = new MediaDevicesFileExplorer();
            FileExplorer.DeviceConnected += FileExplorer_ConnectionStatusChanged;
            DeviceFileExplorer.AttachSource(FileExplorer);
        }

        private void FileExplorer_ConnectionStatusChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(UpdateConnectionStatus));
                return;
            }
            UpdateConnectionStatus();
        }

        private void UpdateConnectionStatus()
        {
            BtReconnect.Enabled = !string.IsNullOrEmpty(FileExplorer.Name);
            LbConnected.BackColor = FileExplorer.IsConnected ? Color.FromArgb(192, 255, 192) : Color.FromKnownColor(KnownColor.Control);
        }

        private void BtSelectDevice_Click(object sender, EventArgs e)
        {
            using (MediaDeviceSelectDialog dlg = new MediaDeviceSelectDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (FileExplorer.ConnectDevice(dlg.SelectedDevice))
                        DeviceFileExplorer.RefreshFolderTreeView();
                }
            }
        }

        private void BtReconnect_Click(object sender, EventArgs e)
        {
            //Force device to reconnect
            FileExplorer.Reconnect();
        }
    }
}
