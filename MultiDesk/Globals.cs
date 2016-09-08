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

        public const int tenD = 419;
        public const int nineD = 377;
        public const int eightD = 335;
        public const int sevenD = 293;
        public const int sixD = 251;
        public const int fiveD = 209;
        public const int fourD = 167;
        public const int threeD = 125;
        public const int twoD = 83;

        public static void Exit()
        {
            Application.Exit();
        }

    }
}
