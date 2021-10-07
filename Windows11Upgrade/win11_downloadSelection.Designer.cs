
namespace Windows11Upgrade
{
    partial class win11_downloadSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win11_downloadSelection));
            this.listLanguages = new System.Windows.Forms.ListBox();
            this.lbl_language = new System.Windows.Forms.Label();
            this.btnDownloadSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLanguages
            // 
            this.listLanguages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLanguages.FormattingEnabled = true;
            this.listLanguages.ItemHeight = 15;
            this.listLanguages.Location = new System.Drawing.Point(12, 33);
            this.listLanguages.Name = "listLanguages";
            this.listLanguages.Size = new System.Drawing.Size(378, 199);
            this.listLanguages.TabIndex = 0;
            this.listLanguages.SelectedIndexChanged += new System.EventHandler(this.languageList_SelectionChange);
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.Location = new System.Drawing.Point(110, 9);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(189, 21);
            this.lbl_language.TabIndex = 2;
            this.lbl_language.Text = "Select system language";
            // 
            // btnDownloadSystem
            // 
            this.btnDownloadSystem.Enabled = false;
            this.btnDownloadSystem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadSystem.Location = new System.Drawing.Point(13, 238);
            this.btnDownloadSystem.Name = "btnDownloadSystem";
            this.btnDownloadSystem.Size = new System.Drawing.Size(377, 42);
            this.btnDownloadSystem.TabIndex = 3;
            this.btnDownloadSystem.Text = "Select language first";
            this.btnDownloadSystem.UseVisualStyleBackColor = true;
            this.btnDownloadSystem.Click += new System.EventHandler(this.btnDownloadSystem_Click);
            // 
            // win11_downloadSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 301);
            this.Controls.Add(this.btnDownloadSystem);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.listLanguages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win11_downloadSelection";
            this.Text = "Windows 11 Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLanguages;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.Button btnDownloadSystem;
    }
}