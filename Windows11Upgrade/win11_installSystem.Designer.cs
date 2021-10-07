
namespace Windows11Upgrade
{
    partial class win11_installSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win11_installSystem));
            this.radUpgrade = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radDataOnly = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radCleanInstall = new System.Windows.Forms.RadioButton();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.btnInstallSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radUpgrade
            // 
            this.radUpgrade.AutoSize = true;
            this.radUpgrade.Checked = true;
            this.radUpgrade.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radUpgrade.Location = new System.Drawing.Point(16, 42);
            this.radUpgrade.Name = "radUpgrade";
            this.radUpgrade.Size = new System.Drawing.Size(87, 24);
            this.radUpgrade.TabIndex = 0;
            this.radUpgrade.TabStop = true;
            this.radUpgrade.Text = "Upgrade";
            this.radUpgrade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Performs an upgrade of Windows saving apps and data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Performs an upgrade of Windows, saving only data (and not apps)";
            // 
            // radDataOnly
            // 
            this.radDataOnly.AutoSize = true;
            this.radDataOnly.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDataOnly.Location = new System.Drawing.Point(16, 99);
            this.radDataOnly.Name = "radDataOnly";
            this.radDataOnly.Size = new System.Drawing.Size(93, 24);
            this.radDataOnly.TabIndex = 2;
            this.radDataOnly.Text = "Data only";
            this.radDataOnly.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Performs a clean install of Windows";
            // 
            // radCleanInstall
            // 
            this.radCleanInstall.AutoSize = true;
            this.radCleanInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCleanInstall.Location = new System.Drawing.Point(16, 155);
            this.radCleanInstall.Name = "radCleanInstall";
            this.radCleanInstall.Size = new System.Drawing.Size(109, 24);
            this.radCleanInstall.TabIndex = 4;
            this.radCleanInstall.Text = "Clean install";
            this.radCleanInstall.UseVisualStyleBackColor = true;
            // 
            // lbl_choice
            // 
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.Location = new System.Drawing.Point(71, 9);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(261, 21);
            this.lbl_choice.TabIndex = 6;
            this.lbl_choice.Text = "Choose one of the options below";
            // 
            // btnInstallSystem
            // 
            this.btnInstallSystem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallSystem.Location = new System.Drawing.Point(23, 212);
            this.btnInstallSystem.Name = "btnInstallSystem";
            this.btnInstallSystem.Size = new System.Drawing.Size(377, 42);
            this.btnInstallSystem.TabIndex = 7;
            this.btnInstallSystem.Text = "Install system";
            this.btnInstallSystem.UseVisualStyleBackColor = true;
            this.btnInstallSystem.Click += new System.EventHandler(this.btnInstallSystem_Click);
            // 
            // win11_installSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 266);
            this.Controls.Add(this.btnInstallSystem);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radCleanInstall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radDataOnly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radUpgrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win11_installSystem";
            this.Text = "Windows 11 Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radUpgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radDataOnly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radCleanInstall;
        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Button btnInstallSystem;
    }
}