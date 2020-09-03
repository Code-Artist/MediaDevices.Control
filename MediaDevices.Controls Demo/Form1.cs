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
