using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FUAC
{
    public partial class Menu : Form
    {
        RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
        int value;

        [DllImport("user32")]
        public static extern uint SendMessage
            (IntPtr hWnd, uint msg, uint wParam, uint lParam);

        internal const int BCM_FIRST = 0x1600; //Normal button
        internal const int BCM_SETSHIELD = (BCM_FIRST + 0x000C); //Elevated button

        public Menu(bool auto)
        {
            if (auto)
            {
                DisableUAC_Click(null, null);
                Environment.Exit(0);
            }

            InitializeComponent();
            if (RegKey != null)
            {
                value = (int)RegKey.GetValue("enablelua", null);
                if (value == 0)
                {
                    DisableUAC.Enabled = false;
                    DisableUAC.Text = "UAC is already disabled";
                }
                else
                {
                    AddShieldToButton(DisableUAC);
                }
            }
        }

        private void DisableUAC_Click(object sender, EventArgs e)
        {
            RegKey.SetValue("consentpromptbehavioradmin", "0", RegistryValueKind.DWord);
            RegKey.SetValue("enablelua", "0", RegistryValueKind.DWord);
            RegKey.SetValue("promptonsecuredesktop", "0", RegistryValueKind.DWord);
            value = (int)RegKey.GetValue("enablelua", null);
            RegKey.Close();

            if (value == 0)
            {
                if (sender != null)
                {
                    MessageBox.Show("UAC successfully disabled - please reboot");
                    DisableUAC.Enabled = false;
                }
            }
        }

        static internal void AddShieldToButton(Button b)
        {
            b.FlatStyle = FlatStyle.System;
            SendMessage(b.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFF);
        }

    }
}
