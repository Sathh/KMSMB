using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace KMSMB
{
    public partial class MainForm : Form
    {
        private Timer refreshTimer = new Timer();
        private bool InDomain { get; set; }
        private bool Elevated { get; set; }
        private string FolderName { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(bool inDomain)
        {
            InitializeComponent();
            this.InDomain = inDomain;
            Initial();
        }
        private void Initial()
        {
            if (InDomain == true)
            {
                MessageBox.Show("Počítač je v doméne a program nemusí pracovať správne !",
                                "Upozornenie !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            RefreshTimer();
            Elevated = IsElevated();
            new Samba();
        }
        private bool IsElevated()
        {
            using (var identity = WindowsIdentity.GetCurrent())
            {
                var principal = new WindowsPrincipal(identity);

                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
        private void RunAsAdmin()
        {
            var path = Assembly.GetExecutingAssembly().Location;
            using (var process = Process.Start(new ProcessStartInfo(path, "/run_elevated_action")
            {
                Verb = "runas"
            }))
            {
                //process?.WaitForExit();
            }
        }
        private string IpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Počítač nie je pripojený k IPv4 sieti");
        }
        private void RefreshTimer()
        {
            refreshTimer.Tick += new EventHandler(RefreshLabel);
            refreshTimer.Interval = 500;
            refreshTimer.Start();
        }
        private void RefreshLabel(Object o, EventArgs e)
        {
            LabelSMB1.Text = Globals.Smb1;
            LabelSMB2.Text = Globals.Smb2;
            LabelSharedFolderName.Text = Globals.SharedFolder;
            Username = Globals.Username;
            Password = Globals.Password;
            LabelIP.Text = Environment.MachineName + "  alebo  " + IpAddress();
            if (string.IsNullOrEmpty(FolderName) == false)
            {
                LabelSharedFolderName.Text = FolderName;
            }
            if (string.IsNullOrEmpty(Username) == false)
            {
                LabelUsername.Text = Username;
            }
            if (string.IsNullOrEmpty(Password) == false)
            {
                LabelPassword.Text = Password;
            }
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                string returnTxt = Clipboard.GetText(TextDataFormat.Text);
                if (returnTxt == LabelPassword.Text)
                {
                    LabelPassword.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    LabelPassword.ForeColor = System.Drawing.Color.Black;
                }
            }
        }
        private void LabelPassword_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Password);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Najskôr musíš vytvoriť užívateľa !", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonUserCreate_Click(object sender, EventArgs e)
        {
            if (Elevated == true)
            {
                UserCreateForm userCreateForm = new UserCreateForm();
                userCreateForm.Show();
            }
            else
            {
                Close();
                RunAsAdmin();
            }
        }

        private void ButtonShareFolder_Click(object sender, EventArgs e)
        {
            if (Elevated == true)
            {
                ShareFolderForm shareFolderForm = new ShareFolderForm();
            }
            else 
            {
                Close();
                RunAsAdmin();
            }
        }

        private void ButtonRemoveUser_Click(object sender, EventArgs e)
        {
            if (Elevated == true)
            {
                MessageBox.Show("Táto akcia sa nedá vratiť späť! \r\nDávaj pozor ktorého uživateľa odstraňuješ", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RemoveUserForm removeUserForm = new RemoveUserForm();
                removeUserForm.Show();
            }
            else
            {
                Close();
                RunAsAdmin();
            }
        }
        private void InfoPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Globals.Password) == false)
                {
                    Clipboard.SetText(Globals.Password);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Najskôr musíš vytvoriť užívateľa !", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InfoPictureBox_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.InfoPictureBox, "Kliknutím sem, skopíruješ heslo do schránky");
        }

        private void ToolStripMenu_StavSiete_Item_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:network-status");
        }

        private void ToolStripMenu_NastaveniaZdielania_Item_Click(object sender, EventArgs e)
        {
            string cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
            Process.Start(cplPath, "/name Microsoft.NetworkAndSharingCenter /page Advanced");
        }
    }
}
