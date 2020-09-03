namespace MediaDevices.Controls
{
    partial class MediaDeviceFolderBrowseDialog
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
            this.FileExplorer = new CodeArtEng.Controls.FileExplorer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtOK = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.LbErrorMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileExplorer
            // 
            this.FileExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileExplorer.FileView = System.Windows.Forms.View.LargeIcon;
            this.FileExplorer.HideSystemFolder = true;
            this.FileExplorer.Location = new System.Drawing.Point(0, 0);
            this.FileExplorer.Name = "FileExplorer";
            this.FileExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.FileExplorer.Size = new System.Drawing.Size(705, 408);
            this.FileExplorer.SplitterDistance = 183;
            this.FileExplorer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbErrorMessage);
            this.panel1.Controls.Add(this.BtCancel);
            this.panel1.Controls.Add(this.BtOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 46);
            this.panel1.TabIndex = 1;
            // 
            // BtOK
            // 
            this.BtOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtOK.Location = new System.Drawing.Point(510, 11);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(102, 26);
            this.BtOK.TabIndex = 0;
            this.BtOK.Text = "Select Folder";
            this.BtOK.UseVisualStyleBackColor = true;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCancel.Location = new System.Drawing.Point(618, 11);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(75, 26);
            this.BtCancel.TabIndex = 1;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // LbErrorMessage
            // 
            this.LbErrorMessage.AutoSize = true;
            this.LbErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LbErrorMessage.Location = new System.Drawing.Point(12, 18);
            this.LbErrorMessage.Name = "LbErrorMessage";
            this.LbErrorMessage.Size = new System.Drawing.Size(87, 13);
            this.LbErrorMessage.TabIndex = 2;
            this.LbErrorMessage.Text = "<Error Message>";
            this.LbErrorMessage.Visible = false;
            // 
            // MediaDeviceFolderBrowseDialog
            // 
            this.AcceptButton = this.BtOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancel;
            this.ClientSize = new System.Drawing.Size(705, 454);
            this.Controls.Add(this.FileExplorer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MediaDeviceFolderBrowseDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Folder...";
            this.Shown += new System.EventHandler(this.MediaDeviceFolderBrowseDialog_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeArtEng.Controls.FileExplorer FileExplorer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbErrorMessage;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BtOK;
    }
}