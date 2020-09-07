namespace MediaDevices.Controls
{
    partial class MediaDeviceSelectDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtCancel = new System.Windows.Forms.Button();
            this.BtOK = new System.Windows.Forms.Button();
            this.GpAndroidDevice = new System.Windows.Forms.GroupBox();
            this.LstDevices = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.GpAndroidDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtCancel);
            this.panel1.Controls.Add(this.BtOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 42);
            this.panel1.TabIndex = 0;
            // 
            // BtCancel
            // 
            this.BtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtCancel.Location = new System.Drawing.Point(371, 9);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 25);
            this.BtCancel.TabIndex = 1;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // BtOK
            // 
            this.BtOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtOK.Location = new System.Drawing.Point(290, 9);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(75, 25);
            this.BtOK.TabIndex = 0;
            this.BtOK.Text = "OK";
            this.BtOK.UseVisualStyleBackColor = true;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // GpAndroidDevice
            // 
            this.GpAndroidDevice.Controls.Add(this.LstDevices);
            this.GpAndroidDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpAndroidDevice.Location = new System.Drawing.Point(5, 5);
            this.GpAndroidDevice.Name = "GpAndroidDevice";
            this.GpAndroidDevice.Size = new System.Drawing.Size(455, 219);
            this.GpAndroidDevice.TabIndex = 1;
            this.GpAndroidDevice.TabStop = false;
            this.GpAndroidDevice.Text = "Connected Android Devices";
            // 
            // LstDevices
            // 
            this.LstDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstDevices.FormattingEnabled = true;
            this.LstDevices.Location = new System.Drawing.Point(28, 36);
            this.LstDevices.Name = "LstDevices";
            this.LstDevices.Size = new System.Drawing.Size(391, 160);
            this.LstDevices.TabIndex = 0;
            this.LstDevices.SelectedIndexChanged += new System.EventHandler(this.LstDevices_SelectedIndexChanged);
            // 
            // MediaDeviceSelectDialog
            // 
            this.AcceptButton = this.BtOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancel;
            this.ClientSize = new System.Drawing.Size(465, 271);
            this.Controls.Add(this.GpAndroidDevice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MediaDeviceSelectDialog";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Device...";
            this.panel1.ResumeLayout(false);
            this.GpAndroidDevice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BtOK;
        private System.Windows.Forms.GroupBox GpAndroidDevice;
        private System.Windows.Forms.ListBox LstDevices;
    }
}