using System;
using System.DirectoryServices.AccountManagement;
using System.Management;
using System.Windows.Forms;

namespace KMSMB
{
    public partial class RemoveUserForm : Form
    {
        public RemoveUserForm()
        {
            InitializeComponent();
            UserList.Items.Clear();
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                UserList.Items.Add(envVar["Name"]);
            }
        }

        private void ButtonSelectUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Naozaj chceš odstrániť užívateľa " + Convert.ToString(UserList.SelectedItem) + " ?", "Upozornenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    PrincipalContext ctx = new PrincipalContext(ContextType.Machine);
                    UserPrincipal usrp = new UserPrincipal(ctx);
                    usrp.Name = Convert.ToString(UserList.SelectedItem);
                    PrincipalSearcher ps_usr = new PrincipalSearcher(usrp);
                    var user = ps_usr.FindOne();
                    user.Delete();
                    MessageBox.Show("Užívateľ " + Convert.ToString(UserList.SelectedItem) + " bol odstránený");
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Nepodarilo sa nájsť užívateľa", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Musíš spustiť program ako SPRÁVCA !", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}