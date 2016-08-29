using System;
using System.Windows.Forms;

namespace MultiDesk
{
    static class Program
    {
        public static string[] Arguments;      
        private static int count = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Arguments[0] = String.Empty;
            foreach (string arg in args)
            {
                Arguments[count] = arg.Trim();
                count++;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
