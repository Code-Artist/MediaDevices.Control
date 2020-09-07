using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MediaDevices.Controls
{
    /// <summary>
    /// Media Device Selector Dialog. Select device based on it's Description.
    /// </summary>
    public partial class MediaDeviceSelectDialog : Form
    {
        /// <summary>
        /// Get or set selected device description.
        /// </summary>
        public string SelectedDevice { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MediaDeviceSelectDialog()
        {
            //this.SetAppIcon();
            InitializeComponent();

            LstDevices.Items.Clear();
            using (MediaManager manager = new MediaManager())
            {
                LstDevices.Items.AddRange(manager.GetDevices().Select(x => x.Description).ToArray());
            }
            if (!string.IsNullOrEmpty(SelectedDevice))
            {
                int id = LstDevices.Items.IndexOf(SelectedDevice);
                if (id != -1) LstDevices.SelectedIndex = id;
            }
            BtOK.Enabled = (LstDevices.SelectedIndex != -1);
        }

        /// <summary>
        /// Execute dialog and return selected device description.
        /// Return null if user clicked "Cancel" button.
        /// </summary>
        /// <param name="selectedDevice"></param>
        /// <returns></returns>
        public string Execute(string selectedDevice = null)
        {
            SelectedDevice = selectedDevice;
            if (ShowDialog() == DialogResult.OK) return SelectedDevice;
            else return null;
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SelectedDevice = LstDevices.Text;
        }

        private void LstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtOK.Enabled = (LstDevices.SelectedIndex != -1);
        }
    }
}
