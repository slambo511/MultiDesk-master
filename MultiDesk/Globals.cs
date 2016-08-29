using System;
using System.Windows.Forms;

namespace MultiDesk
{
    class Globals
    {
        public static int NoDesktops = 6;
        public static int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        public static int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;        
        public static int[] TopLeft = { 10, 10 };
        public static int[] TopCentre = { ((ScreenWidth / 2) - 143), 10 };
        public static int[] TopRight = { (ScreenWidth - 286), 10 };
        public static int[] CentreLeft = { 10, ((ScreenHeight / 2) - 25) };
        public static int[] CentreRight = { (ScreenWidth - 286), ((ScreenHeight / 2) - 25) };
        public static int[] BottomLeft = { 10, (ScreenHeight - (ScreenHeight - 10)) };
        public static int[] BottomCentre = { ((ScreenWidth / 2) - 143), (ScreenHeight - (ScreenHeight - 10)) };
        public static int[] BottomRight = { (ScreenWidth - 286), (ScreenHeight - (ScreenHeight - 10)) };
        public static int[] ScreenPosition = TopCentre;
        public static bool IsFloating = false;

        public static void Exit()
        {
            Application.Exit();
        }

    }
}
