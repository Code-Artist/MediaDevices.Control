namespace MediaDevices.Controls_Demo
{
    partial class Form1
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
            this.fileExplorer1 = new CodeArtEng.Controls.FileExplorer();
            this.BtConnect = new System.Windows.Forms.Button();
            this.BtAttachSource = new System.Windows.Forms.Button();
            this.BtSelectDevice = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mediaDeviceFileBrowser1 = new MediaDevices.Controls.MediaDeviceFileBrowser();
            this.TabMediaFolder = new System.Windows.Forms.TabPage();
            this.BtSelectFolder = new System.Windows.Forms.Button();
            this.TxtFolder = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TabMediaFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileExplorer1
            // 
            this.fileExplorer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileExplorer1.FileView = System.Windows.Forms.View.LargeIcon;
            this.fileExplorer1.HideSystemFolder = true;
            this.fileExplorer1.Location = new System.Drawing.Point(8, 35);
            this.fileExplorer1.Name = "fileExplorer1";
            this.fileExplorer1.Size = new System.Drawing.Size(1063, 540);
            this.fileExplorer1.SplitterDistance = 183;
            this.fileExplorer1.TabIndex = 0;
            // 
            // BtConnect
            // 
            this.BtConnect.Location = new System.Drawing.Point(144, 6);
            this.BtConnect.Name = "BtConnect";
            this.BtConnect.Size = new System.Drawing.Size(75, 23);
            this.BtConnect.TabIndex = 1;
            this.BtConnect.Text = "Connect";
            this.BtConnect.UseVisualStyleBackColor = true;
            this.BtConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // BtAttachSource
            // 
            this.BtAttachSource.Location = new System.Drawing.Point(6, 6);
            this.BtAttachSource.Name = "BtAttachSource";
            this.BtAttachSource.Size = new System.Drawing.Size(132, 23);
            this.BtAttachSource.TabIndex = 2;
            this.BtAttachSource.Text = "Attach Source";
            this.BtAttachSource.UseVisualStyleBackColor = true;
            this.BtAttachSource.Click += new System.EventHandler(this.BtAttachSource_Click);
            // 
            // BtSelectDevice
            // 
            this.BtSelectDevice.Location = new System.Drawing.Point(255, 6);
            this.BtSelectDevice.Name = "BtSelectDevice";
            this.BtSelectDevice.Size = new System.Drawing.Size(117, 23);
            this.BtSelectDevice.TabIndex = 3;
            this.BtSelectDevice.Text = "Select Device";
            this.BtSelectDevice.UseVisualStyleBackColor = true;
            this.BtSelectDevice.Click += new System.EventHandler(this.BtSelectDevice_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.TabMediaFolder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 609);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtAttachSource);
            this.tabPage1.Controls.Add(this.fileExplorer1);
            this.tabPage1.Controls.Add(this.BtSelectDevice);
            this.tabPage1.Controls.Add(this.BtConnect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Implementation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mediaDeviceFileBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MediaDeviceFileBrowser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mediaDeviceFileBrowser1
            // 
            this.mediaDeviceFileBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaDeviceFileBrowser1.Location = new System.Drawing.Point(3, 3);
            this.mediaDeviceFileBrowser1.Name = "mediaDeviceFileBrowser1";
            this.mediaDeviceFileBrowser1.Padding = new System.Windows.Forms.Padding(3);
            this.mediaDeviceFileBrowser1.Size = new System.Drawing.Size(1073, 577);
            this.mediaDeviceFileBrowser1.TabIndex = 0;
            // 
            // TabMediaFolder
            // 
            this.TabMediaFolder.Controls.Add(this.BtSelectFolder);
            this.TabMediaFolder.Controls.Add(this.TxtFolder);
            this.TabMediaFolder.Location = new System.Drawing.Point(4, 22);
            this.TabMediaFolder.Name = "TabMediaFolder";
            this.TabMediaFolder.Padding = new System.Windows.Forms.Padding(3);
            this.TabMediaFolder.Size = new System.Drawing.Size(1079, 583);
            this.TabMediaFolder.TabIndex = 2;
            this.TabMediaFolder.Text = "Media Folder Browse";
            this.TabMediaFolder.UseVisualStyleBackColor = true;
            // 
            // BtSelectFolder
            // 
            this.BtSelectFolder.Location = new System.Drawing.Point(388, 35);
            this.BtSelectFolder.Name = "BtSelectFolder";
            this.BtSelectFolder.Size = new System.Drawing.Size(176, 23);
            this.BtSelectFolder.TabIndex = 1;
            this.BtSelectFolder.Text = "Select Folder";
            this.BtSelectFolder.UseVisualStyleBackColor = true;
            this.BtSelectFolder.Click += new System.EventHandler(this.BtSelectFolder_Click);
            // 
            // TxtFolder
            // 
            this.TxtFolder.Location = new System.Drawing.Point(21, 37);
            this.TxtFolder.Name = "TxtFolder";
            this.TxtFolder.Size = new System.Drawing.Size(361, 20);
            this.TxtFolder.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.TabMediaFolder.ResumeLayout(false);
            this.TabMediaFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeArtEng.Controls.FileExplorer fileExplorer1;
        private System.Windows.Forms.Button BtConnect;
        private System.Windows.Forms.Button BtAttachSource;
        private System.Windows.Forms.Button BtSelectDevice;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.MediaDeviceFileBrowser mediaDeviceFileBrowser1;
        private System.Windows.Forms.TabPage TabMediaFolder;
        private System.Windows.Forms.Button BtSelectFolder;
        private System.Windows.Forms.TextBox TxtFolder;
    }
}

