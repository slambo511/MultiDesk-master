using System;
using System.Windows.Forms;

namespace MultiDesk
{
    class Globals
    {
        public static int NoDesktops = 6;
        public static int RemainingDesktops = NoDesktops - 1;
        public static int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        public static int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;

        public static IntPtr Handledefault = Desktops.DesktopOpen("default");
        public static IntPtr Handledesktop1 = Desktops.DesktopOpen("desktop2");
        public static IntPtr Handledesktop3 = Desktops.DesktopOpen("desktop3");
        public static IntPtr Handledesktop4 = Desktops.DesktopOpen("desktop4");
        public static IntPtr Handledesktop5 = Desktops.DesktopOpen("desktop5");
        public static IntPtr Handledesktop6 = Desktops.DesktopOpen("desktop6");
        public static IntPtr Handledesktop7 = Desktops.DesktopOpen("desktop7");
        public static IntPtr Handledesktop8 = Desktops.DesktopOpen("desktop8");

        public static void Exit()
        {
            Application.Exit();
        }

    }
}
