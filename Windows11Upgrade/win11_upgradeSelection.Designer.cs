
namespace Windows11Upgrade
{
    partial class win11_upgradeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win11_upgradeSelection));
            this.lbl_choice = new System.Windows.Forms.Label();
            this.btn_selectIso = new System.Windows.Forms.Button();
            this.btn_downloadIso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_choice
            // 
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.Location = new System.Drawing.Point(59, 9);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(261, 21);
            this.lbl_choice.TabIndex = 0;
            this.lbl_choice.Text = "Choose one of the options below";
            // 
            // btn_selectIso
            // 
            this.btn_selectIso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectIso.Location = new System.Drawing.Point(12, 42);
            this.btn_selectIso.Name = "btn_selectIso";
            this.btn_selectIso.Size = new System.Drawing.Size(346, 23);
            this.btn_selectIso.TabIndex = 2;
            this.btn_selectIso.Text = "Select Windows 11 ISO file";
            this.btn_selectIso.UseVisualStyleBackColor = true;
            this.btn_selectIso.Click += new System.EventHandler(this.btn_selectIso_Click);
            // 
            // btn_downloadIso
            // 
            this.btn_downloadIso.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadIso.Location = new System.Drawing.Point(12, 71);
            this.btn_downloadIso.Name = "btn_downloadIso";
            this.btn_downloadIso.Size = new System.Drawing.Size(346, 23);
            this.btn_downloadIso.TabIndex = 3;
            this.btn_downloadIso.Text = "Download Windows 11 ISO file";
            this.btn_downloadIso.UseVisualStyleBackColor = true;
            this.btn_downloadIso.Click += new System.EventHandler(this.btn_downloadIso_Click);
            // 
            // win11_upgradeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 115);
            this.Controls.Add(this.btn_downloadIso);
            this.Controls.Add(this.btn_selectIso);
            this.Controls.Add(this.lbl_choice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win11_upgradeSelection";
            this.Text = "Windows 11 Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Button btn_selectIso;
        private System.Windows.Forms.Button btn_downloadIso;
    }
}

