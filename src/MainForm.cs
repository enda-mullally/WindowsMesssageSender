using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinMessageSender.Helpers;
using WinMessageSender.Shell;

namespace WinMessageSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            uxcboMessageType.SelectedIndex = 0;

            uxtxtMessage_TextChanged(sender, EventArgs.Empty);
        }

        // ReSharper disable once IdentifierTypo
        private void uxbtnSend_Click(object sender, EventArgs e)
        {
            var handle = IntParser.ParseInt32(uxtxtHandle.Text);
            var message = IntParser.ParseInt32(uxtxtMessage.Text);
            if (uxchkPlusWmUser.Checked)
            {
                message += User32.WmUser;
            }

            var wParam = (uint)IntParser.ParseInt32(uxtxtWParam.Text);
            var lParam = (uint)IntParser.ParseInt32(uxtxtLParaam.Text);
            var result = string.Empty;
            var lastError = 0;

            switch (uxcboMessageType.SelectedIndex)
            {
                case 0:
                {
                    // PostMessage
                    result = User32.PostMessage(handle, message, wParam, lParam).ToString();
                    lastError = Marshal.GetLastWin32Error();
                    
                    break;
                }
                case 1:
                {
                    // SendMessage
                    result = User32.SendMessage(handle, message, wParam, lParam).ToString();
                    break;
                }
            }

            uxlblResult.Text = $@"Result = {result}";

            if (lastError <= 0)
            {
                return;
            }

            Marshal.ThrowExceptionForHR(lastError);

            uxlblResult.Text += $@", GetLastError() = {lastError}, {Kernel32.GetLastErrorString(lastError)}";
        }

        private void uxtxtMessage_TextChanged(object sender, EventArgs e)
        {
            uxbtnSend.Enabled = uxtxtMessage.Text.Trim().Length > 0 &&
                                uxtxtHandle.Text.Trim().Length > 0 &&
                                uxtxtWParam.Text.Trim().Length > 0 &&
                                uxtxtLParaam.Text.Trim().Length > 0;

            uxlblResult.Text = @"Result =";
        }
    }
}
