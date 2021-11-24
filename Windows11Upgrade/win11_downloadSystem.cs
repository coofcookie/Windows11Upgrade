using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Windows11Upgrade {
    public partial class win11_downloadSystem : Form {
        public win11_downloadSystem() {
            InitializeComponent();
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            BeginInvoke((MethodInvoker) delegate {
                var percentage = (double)(e.BytesReceived * 100) / e.TotalBytesToReceive;
                lblDownloadPercentage.Text = $"{Math.Round(percentage, 1)} %";
                progressDownload.Value = (int)percentage;
            });
        }

        private void downloadCompleted(object sender, AsyncCompletedEventArgs e) {
            BeginInvoke((MethodInvoker) delegate {
                globals.isoPath = Directory.GetCurrentDirectory() + "/win11.iso";
                Hide();
                var installSystem = new win11_installSystem();
                installSystem.Show();
            });
        }

        private void formLoad(object sender, EventArgs e) {
            var client = new WebClient();
            client.DownloadProgressChanged += downloadProgressChanged;
            client.DownloadFileCompleted += downloadCompleted;
            client.DownloadFileAsync(new Uri(globals.downloadURL), @"win11.iso");
        }

        private void exit(object sender, FormClosingEventArgs e) {
            Environment.Exit(0);
        }
    }
}