using System;
using System.Windows.Forms;

namespace SkarLauncher
{
    internal static class Program
    {

        private static Config config;
        public static Config getConfig() { return config; }

        [STAThread]
        static void Main()
        {
            config = new Config();
            config.initConfig();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new skarLauncherForm());
        }
    }
}
