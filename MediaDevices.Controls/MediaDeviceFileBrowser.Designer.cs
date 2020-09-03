namespace MediaDevices.Controls
{
    partial class MediaDeviceFileBrowser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaDeviceFileBrowser));
            this.DeviceFileExplorer = new CodeArtEng.Controls.FileExplorer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtReconnect = new System.Windows.Forms.ToolStripButton();
            this.BtSelectDevice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LbConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeviceFileExplorer
            // 
            this.DeviceFileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceFileExplorer.FileView = System.Windows.Forms.View.LargeIcon;
            this.DeviceFileExplorer.HideSystemFolder = true;
            this.DeviceFileExplorer.Location = new System.Drawing.Point(3, 28);
            this.DeviceFileExplorer.Name = "DeviceFileExplorer";
            this.DeviceFileExplorer.Size = new System.Drawing.Size(715, 456);
            this.DeviceFileExplorer.SplitterDistance = 183;
            this.DeviceFileExplorer.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtSelectDevice,
            this.toolStripSeparator1,
            this.BtReconnect});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtReconnect
            // 
            this.BtReconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtReconnect.Image = ((System.Drawing.Image)(resources.GetObject("BtReconnect.Image")));
            this.BtReconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtReconnect.Name = "BtReconnect";
            this.BtReconnect.Size = new System.Drawing.Size(67, 22);
            this.BtReconnect.Text = "Reconnect";
            this.BtReconnect.Click += new System.EventHandler(this.BtReconnect_Click);
            // 
            // BtSelectDevice
            // 
            this.BtSelectDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtSelectDevice.Image = ((System.Drawing.Image)(resources.GetObject("BtSelectDevice.Image")));
            this.BtSelectDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSelectDevice.Name = "BtSelectDevice";
            this.BtSelectDevice.Size = new System.Drawing.Size(80, 22);
            this.BtSelectDevice.Text = "Select Device";
            this.BtSelectDevice.Click += new System.EventHandler(this.BtSelectDevice_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbConnected});
            this.statusStrip1.Location = new System.Drawing.Point(3, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LbConnected
            // 
            this.LbConnected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.LbConnected.Name = "LbConnected";
            this.LbConnected.Size = new System.Drawing.Size(69, 19);
            this.LbConnected.Text = "Connected";
            // 
            // MediaDeviceFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeviceFileExplorer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MediaDeviceFileBrowser";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(721, 511);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CodeArtEng.Controls.FileExplorer DeviceFileExplorer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtSelectDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtReconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LbConnected;
    }
}
