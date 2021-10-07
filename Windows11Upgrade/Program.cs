using System;
using System.Windows.Forms;

namespace Windows11Upgrade {
    internal static class Program {
        [STAThread]
        private static void Main() {
            bool is32bit = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
            if (is32bit) {
                MessageBox.Show("32-bit systems are not supported!");
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new win11_upgradeSelection());
        }
    }
}