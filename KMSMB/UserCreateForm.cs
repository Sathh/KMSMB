using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace KMSMB
{
    public partial class UserCreateForm : Form
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserCreateForm()
        {
            InitializeComponent();
        }
        private void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtBoxUsername.Text))
            {
                MessageBox.Show("Musíš zadať meno užívateľa !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrWhiteSpace(TxtBoxPassword.Text))
            {
                MessageBox.Show("Musíš zadať heslo !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                try
                {
                    this.Username = TxtBoxUsername.Text;
                    this.Password = TxtBoxPassword.Text;
                    Globals.Username = Username;
                    Globals.Password = Password;
                    PrincipalContext context = new PrincipalContext(ContextType.Machine);
                    UserPrincipal user = new UserPrincipal(context);
                    user.SetPassword(Password);
                    user.DisplayName = Username;
                    user.Name = Username;
                    user.Description = "Profil na skenovanie";
                    user.UserCannotChangePassword = true;
                    user.PasswordNeverExpires = true;
                    user.Save();
                    MessageBox.Show("Užívatel " + Username + " bol vytvorený!", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //GroupPrincipal group = GroupPrincipal.FindByIdentity(context, "Users");
                    //group.Members.Add(user);
                    //group.Save();
                }
                catch (PrincipalExistsException)
                {
                    MessageBox.Show("Užívateľ " + TxtBoxUsername.Text + " už existuje", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Musíš spustiť program ako SPRÁVCA", "Upozornenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (PasswordException)
                {
                    MessageBox.Show("Heslo nespĺňa požiadavky politiky !", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}