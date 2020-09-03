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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mediaDeviceFileBrowser1 = new MediaDevices.Controls.MediaDeviceFileBrowser();
            this.TabMediaFolder = new System.Windows.Forms.TabPage();
            this.BtSelectFolder = new System.Windows.Forms.Button();
            this.TxtFolder = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TabMediaFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.TabMediaFolder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 609);
            this.tabControl1.TabIndex = 4;
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
            this.tabPage2.ResumeLayout(false);
            this.TabMediaFolder.ResumeLayout(false);
            this.TabMediaFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.MediaDeviceFileBrowser mediaDeviceFileBrowser1;
        private System.Windows.Forms.TabPage TabMediaFolder;
        private System.Windows.Forms.Button BtSelectFolder;
        private System.Windows.Forms.TextBox TxtFolder;
    }
}

