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
        public static int[] TopCentre = { 10, ((ScreenWidth / 2) - 143) };
        public static int[] TopRight = { 10, (ScreenWidth - 286) };
        public static int[] CentreLeft = { ((ScreenHeight / 2) - 25), 10 };
        public static int[] CentreRight = { ((ScreenHeight / 2) - 25), (ScreenWidth - 286) };
        public static int[] BottomLeft = { (ScreenHeight - (ScreenHeight - 10)), 10 };
        public static int[] BottomCentre = { (ScreenHeight - (ScreenHeight - 10)), ((ScreenWidth / 2) - 143) };
        public static int[] BottomRight = { (ScreenHeight - (ScreenHeight - 10)), (ScreenWidth - 286) };
        public static int[] ScreenPosition = TopCentre;
        public static bool IsFloating = false;
    }
}
