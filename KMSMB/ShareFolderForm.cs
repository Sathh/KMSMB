using System;
using System.IO;
using System.Management;
using System.Security.Principal;
using System.Windows.Forms;

namespace KMSMB
{
    public partial class ShareFolderForm : Form
    {
        public ShareFolderForm()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(Globals.Username) == false)
            {
                this.Hide();
                FolderBrowserDialog fBD = new FolderBrowserDialog();
                if (fBD.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Nebol vybraný žiadny priečinok!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Share(fBD.SelectedPath, Globals.Username);
                Close();
            }
            if (string.IsNullOrEmpty(Globals.Username) == true)
            {
                this.Show();
                SelectQuery query = new SelectQuery("Win32_UserAccount");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
                foreach (ManagementObject envVar in searcher.Get())
                {
                    UserList.Items.Add(envVar["Name"]);
                }
            }
        }

        private void Share(string path, string user)
        {
            try
            {
                if (MessageBox.Show("Naozaj chceš vyzdielať " + path + " ?", "Upozornenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                string accountToAccess = user;
                string shareName = Path.GetFileName(path);
                Globals.SharedFolder = shareName;
                ManagementClass managementClass = new ManagementClass("Win32_Share");
                ManagementBaseObject inParams = managementClass.GetMethodParameters("Create");
                ManagementBaseObject outParams;
                inParams["Description"] = "Konica Minolta Sken";
                inParams["Name"] = shareName;
                inParams["Path"] = path;
                inParams["Type"] = 0x0;
                inParams["Password"] = null;
                NTAccount NTAccount = new NTAccount(accountToAccess);
                SecurityIdentifier sid = (SecurityIdentifier)NTAccount.Translate(typeof(SecurityIdentifier));
                byte[] sidArray = new byte[sid.BinaryLength];
                sid.GetBinaryForm(sidArray, 0);
                ManagementObject trustee = new ManagementClass("Win32_Trustee");
                trustee["Domain"] = null;
                trustee["Name"] = accountToAccess;
                trustee["SID"] = sidArray;
                ManagementObject dacl = new ManagementClass("Win32_Ace");
                dacl["AccessMask"] = 2032127;
                dacl["AceFlags"] = 3;
                dacl["AceType"] = 0;
                dacl["Trustee"] = trustee;
                ManagementObject securityDescriptor = new ManagementClass("Win32_SecurityDescriptor");
                securityDescriptor["ControlFlags"] = 4;
                securityDescriptor["DACL"] = new object[] { dacl };
                inParams["Access"] = securityDescriptor;
                outParams = managementClass.InvokeMethod("Create", inParams, null);
                var result = (uint)(outParams.Properties["ReturnValue"].Value);
                MessageBox.Show("Priečinok " + path + " bol úspešne vyzdielaný");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Najskôr musíš vytvoriť užívateľa", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Musíš spustiť program ako SPRÁVCA", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonSelectUser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new FolderBrowserDialog();
            if (fBD.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Nebol vybraný žiadny priečinok!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Share(fBD.SelectedPath, UserList.SelectedItem.ToString());
        }
    }
}