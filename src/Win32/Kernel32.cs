using System;
using System.Runtime.InteropServices;
using System.Text;

// ReSharper disable InconsistentNaming

namespace WinMessageSender.Win32
{
    [ComVisible(false)]
    public sealed class Kernel32
    {
        [Flags]
        private enum FORMAT_MESSAGE : uint
        {
            ALLOCATE_BUFFER = 0x00000100,
            IGNORE_INSERTS = 0x00000200,
            FROM_SYSTEM = 0x00001000
        }

        [DllImport("kernel32")]
        private static extern int FormatMessage(
            FORMAT_MESSAGE dwFlags,
            IntPtr lpSource,
            int dwMessageId,
            uint dwLanguageId,
            out StringBuilder msgOut,
            int nSize,
            IntPtr Arguments);

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value",
            Justification = "PInvoke memory management")]
        public static string GetLastErrorString(int lastError)
        {
            if (0 == lastError)
            {
                return string.Empty;
            }

            var msgOut = new StringBuilder(256);

            _ = FormatMessage(
                FORMAT_MESSAGE.ALLOCATE_BUFFER | FORMAT_MESSAGE.FROM_SYSTEM | FORMAT_MESSAGE.IGNORE_INSERTS,
                IntPtr.Zero,
                lastError,
                0,
                out msgOut, msgOut.Capacity, IntPtr.Zero);

            return (msgOut.ToString().Trim());
        }
    }
}
