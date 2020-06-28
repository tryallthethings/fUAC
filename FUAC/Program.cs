using System;
using System.Windows.Forms;

namespace FUAC
{
    static class Program
    {
        static string[] args = Environment.GetCommandLineArgs();
        public static bool auto = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            foreach (string arg in args)
            {
                if (arg == "fo")
                {
                    auto = true;
                }
            }

            Application.Run(new Menu(auto));
        }
    }
}
