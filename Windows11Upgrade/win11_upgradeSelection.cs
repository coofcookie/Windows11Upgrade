using System;
using System.Windows.Forms;

namespace Windows11Upgrade {
    public partial class win11_upgradeSelection : Form {
        public win11_upgradeSelection() {
            InitializeComponent();
        }

        private void btn_selectIso_Click(object sender, EventArgs e) {
            using (var fileDialog = new OpenFileDialog()) {
                fileDialog.InitialDirectory = "c:\\";
                fileDialog.Filter = "ISO file (*.iso)|*.iso";
                fileDialog.FilterIndex = 1;

                if (fileDialog.ShowDialog() == DialogResult.OK) {
                    globals.isoPath = fileDialog.FileName;
                    Hide();
                    var installSystem = new win11_installSystem();
                    installSystem.Show();
                }
            }
        }

        private void btn_downloadIso_Click(object sender, EventArgs e) {
            Hide();
            var downloadSelection = new win11_downloadSelection();
            downloadSelection.Show();
        }

        private void exit(object sender, FormClosingEventArgs e) {
            Environment.Exit(0);
        }
    }
}