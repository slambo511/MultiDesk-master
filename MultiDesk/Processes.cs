using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MultiDesk
{
    public class Processes
    {
        [DllImport("kernel32.dll")]
        public static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            bool bInheritHandles,
            int dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            ref STARTUPINFO lpStartupinfo,
            ref PROCESS_INFORMATION lpProcessInformation
            );

        [StructLayout(LayoutKind.Sequential)]
        // ReSharper disable once InconsistentNaming
        public struct STARTUPINFO
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public int dwX;
            public int dwY;
            public int dwXSize;
            public int dwYSize;
            public int dwXCountChars;
            public int dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lbReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        // ReSharper disable once InconsistentNaming
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        // ReSharper disable once InconsistentNaming
        private const int NORMAL_PRIORITY_CLASS = 0x00000020;

        public static bool ProcessCreate(string name, string path, string args)
        {
            try
            {
                PROCESS_INFORMATION processInformation = new PROCESS_INFORMATION();
                STARTUPINFO startupInfo = new STARTUPINFO();
                startupInfo.cb = Marshal.SizeOf(startupInfo);
                startupInfo.lpDesktop = name;
                string path2 = $"\"{path}\" {args}";
                bool result = CreateProcess(path, path2, IntPtr.Zero, IntPtr.Zero, true, NORMAL_PRIORITY_CLASS,
                    IntPtr.Zero, null, ref startupInfo, ref processInformation);
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }

    }
}
