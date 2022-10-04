using System.Runtime.InteropServices;

namespace WinMessageSender.Win32
{
    [ComVisible(false)]
    public sealed class User32
    {
        // P/Invoke constants
        public const int WmUser = 0x0400;

        // P/Invoke declarations
        [DllImport("user32", EntryPoint = "SendMessage", SetLastError = true)]
        public static extern uint SendMessage(int hWnd, int msg, uint wParam, uint lParam);

        [DllImport("user32", EntryPoint = "PostMessage", SetLastError = true)]
        public static extern bool PostMessage(int hWnd, int msg, uint wParam, uint lParam);
    }
}