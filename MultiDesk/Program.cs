﻿using System;
using System.Windows.Forms;

namespace MultiDesk
{
    static class Program
    {
        public static string[] Arguments = {string.Empty, String.Empty};      
        private static int count = 0;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
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
