using System;
using System.Windows.Forms;

namespace Windows11Upgrade {
    internal static class Program {
        [STAThread]
        private static void Main() {
            if (!Environment.Is64BitOperatingSystem) {
                MessageBox.Show("32-bit systems are not supported!");
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new win11_upgradeSelection());
        }
    }
}