using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiDesk
{
    public class Desktops
    {
        [DllImport("user32.dll")]
        public static extern IntPtr CreateDestop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, 
            int dwFlags, long dwDesiredAccess, IntPtr lpsa);
        [DllImport("user32.dll")]
        public static extern IntPtr OpenDesktop(string lpszDesktop, int dwFlags, bool fInherit,
            long dwDesiredAccess);
        [DllImport("user32.dll")]
        public static extern IntPtr OpenInputDesktop(int dwFlags, bool fInherit, long dwDesiredAccess);
        [DllImport("user32.dll")]
        public static extern bool SwitchDesktop(IntPtr hDesktop);
        [DllImport("user32.dll")]
        public static extern bool CloseDesktop(IntPtr hDesktop);
        [DllImport("user32.dll")]
        private static extern bool GetUserObjectInformation(IntPtr hObj, int nIndex, IntPtr pvInfo,
            int nLength, ref int lpnLengthNeeded);

        private const long DESKTOP_CREATEWINDOW = 0x0002L;
        private const long DESKTOP_ENUMERATE = 0x0040L;
        private const long DESKTOP_WRITEOBJECTS = 0x0080L;
        private const long DESKTOP_SWITCHDESKTOP = 0x0100L;
        private const long DESKTOP_CREATEMENU = 0x0004L;
        private const long DESKTOP_HOOKCONTROL = 0x0008L;
        private const long DESKTOP_READOBJECTS = 0x0001L;
        private const long DESKTOP_JOURNALRECORD = 0x0010L;
        private const long DESKTOP_JOURNALPLAYBACK = 0x0020L;

        private const long RIGHTS =
            DESKTOP_CREATEWINDOW |
            DESKTOP_ENUMERATE |
            DESKTOP_WRITEOBJECTS |
            DESKTOP_SWITCHDESKTOP |
            DESKTOP_CREATEMENU |
            DESKTOP_HOOKCONTROL |
            DESKTOP_READOBJECTS |
            DESKTOP_JOURNALRECORD |
            DESKTOP_JOURNALPLAYBACK;

        public static IntPtr DesktopCreate(string name)
        {
            return CreateDestop(name, IntPtr.Zero, IntPtr.Zero, 0, RIGHTS, IntPtr.Zero);
        }

        public static IntPtr DesktopOpen(string name)
        {
            return OpenDesktop(name, 0, true, RIGHTS);
        }

        public static IntPtr DesktopOpenInput()
        {
            return OpenInputDesktop(0, true, RIGHTS);
        }

        public static bool DesktopSwitch(string name)
        {
            IntPtr handle = DesktopOpen(name);
            if (handle == IntPtr.Zero)
            {
                return false;
            }
            return SwitchDesktop(handle);
        }

        public static bool DesktopClose(string name)
        {
            IntPtr handle = DesktopOpen(name);
            if (handle == IntPtr.Zero)
            {
                return false;
            }
            return CloseDesktop(handle);
        }

        public static bool DesktopExists(string name)
        {
            IntPtr handle = DesktopOpen(name);
            if (handle == IntPtr.Zero)
            {
                return false;
            }
            return true;
        }

        public static string DesktopName(IntPtr handle)
        {
            if (handle == IntPtr.Zero)
            {
                return string.Empty;
            }
            int length = 0;
            GetUserObjectInformation(handle, 2, IntPtr.Zero, 0, ref length);
            IntPtr pointer = Marshal.AllocHGlobal(length);
            bool result = GetUserObjectInformation(handle, 2, pointer, length, ref length);
            string name = Marshal.PtrToStringAnsi(pointer);
            Marshal.FreeHGlobal(pointer);
            if (!result)
            {
                return string.Empty;
            }
            return name;
        }

    }
}
