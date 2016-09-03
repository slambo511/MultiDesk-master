using System.Windows.Forms;

namespace MultiDesk
{
    class Globals
    {
        public static int NoDesktops = 6;
        public static int RemainingDesktops = NoDesktops - 1;
        public static int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        public static int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;

        public static void Exit()
        {
            Application.Exit();
        }

    }
}
