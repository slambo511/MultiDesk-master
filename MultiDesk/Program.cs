using System;
using System.Windows.Forms;

namespace MultiDesk
{
    static class Program
    {
        public static string[] Arguments = {string.Empty, string.Empty, "1"};      
        private static int _count;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Arguments[_count] = arg.Trim();
                _count++;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
