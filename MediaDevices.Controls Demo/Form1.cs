using MediaDevices.Controls;
using System;
using System.Windows.Forms;

namespace MediaDevices.Controls_Demo
{
    public partial class Form1 : Form
    {
        private readonly MediaDevicesFileExplorer MediaFileExplorer;
        public Form1()
        {
            InitializeComponent();

            MediaFileExplorer = new MediaDevicesFileExplorer();
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            MediaFileExplorer.ConnectDevice("Redmi 4X");
            fileExplorer1.RefreshFolderTreeView();
        }

        private void BtAttachSource_Click(object sender, EventArgs e)
        {
            fileExplorer1.AttachSource(MediaFileExplorer);
        }

        private void BtSelectDevice_Click(object sender, EventArgs e)
        {
            using (MediaDeviceSelectDialog dlg = new MediaDeviceSelectDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    MediaFileExplorer.ConnectDevice(dlg.SelectedDevice);
                }
            }
        }

        private void BtSelectFolder_Click(object sender, EventArgs e)
        {
            using (MediaDeviceFolderBrowseDialog dialog = new MediaDeviceFolderBrowseDialog("Redmi 4X"))
            {
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    TxtFolder.Text = dialog.SelectedFolder;
                }
            }
        }
    }
}
