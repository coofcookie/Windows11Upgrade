
namespace Windows11Upgrade
{
    partial class win11_downloadSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win11_downloadSystem));
            this.progressDownload = new System.Windows.Forms.ProgressBar();
            this.lblDownloadPercentage = new System.Windows.Forms.Label();
            this.lblDownloadingSystem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressDownload
            // 
            this.progressDownload.Location = new System.Drawing.Point(13, 13);
            this.progressDownload.Name = "progressDownload";
            this.progressDownload.Size = new System.Drawing.Size(427, 23);
            this.progressDownload.TabIndex = 0;
            // 
            // lblDownloadPercentage
            // 
            this.lblDownloadPercentage.AutoSize = true;
            this.lblDownloadPercentage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadPercentage.Location = new System.Drawing.Point(9, 39);
            this.lblDownloadPercentage.Name = "lblDownloadPercentage";
            this.lblDownloadPercentage.Size = new System.Drawing.Size(33, 20);
            this.lblDownloadPercentage.TabIndex = 1;
            this.lblDownloadPercentage.Text = "0 %";
            // 
            // lblDownloadingSystem
            // 
            this.lblDownloadingSystem.AutoSize = true;
            this.lblDownloadingSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadingSystem.Location = new System.Drawing.Point(9, 76);
            this.lblDownloadingSystem.Name = "lblDownloadingSystem";
            this.lblDownloadingSystem.Size = new System.Drawing.Size(246, 20);
            this.lblDownloadingSystem.TabIndex = 2;
            this.lblDownloadingSystem.Text = "Downloading system, please wait...";
            // 
            // win11_downloadSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 105);
            this.Controls.Add(this.lblDownloadingSystem);
            this.Controls.Add(this.lblDownloadPercentage);
            this.Controls.Add(this.progressDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win11_downloadSystem";
            this.Text = "Windows 11 Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.Load += new System.EventHandler(this.formLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressDownload;
        private System.Windows.Forms.Label lblDownloadPercentage;
        private System.Windows.Forms.Label lblDownloadingSystem;
    }
}