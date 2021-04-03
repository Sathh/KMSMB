
namespace KMSMB
{
    partial class UserCreateForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreateForm));
            this.TxtBoxUsername = new System.Windows.Forms.TextBox();
            this.TxtBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonCreateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxUsername
            // 
            this.TxtBoxUsername.Location = new System.Drawing.Point(115, 12);
            this.TxtBoxUsername.Name = "TxtBoxUsername";
            this.TxtBoxUsername.Size = new System.Drawing.Size(158, 20);
            this.TxtBoxUsername.TabIndex = 0;
            this.TxtBoxUsername.Text = "minolta";
            // 
            // TxtBoxPassword
            // 
            this.TxtBoxPassword.Location = new System.Drawing.Point(115, 38);
            this.TxtBoxPassword.Name = "TxtBoxPassword";
            this.TxtBoxPassword.Size = new System.Drawing.Size(158, 20);
            this.TxtBoxPassword.TabIndex = 1;
            this.TxtBoxPassword.Text = "minolta";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(12, 15);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(98, 13);
            this.LabelUsername.TabIndex = 2;
            this.LabelUsername.Text = "Užívateľské meno:";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(73, 41);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(37, 13);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Heslo:";
            // 
            // ButtonCreateUser
            // 
            this.ButtonCreateUser.Location = new System.Drawing.Point(115, 64);
            this.ButtonCreateUser.Name = "ButtonCreateUser";
            this.ButtonCreateUser.Size = new System.Drawing.Size(158, 54);
            this.ButtonCreateUser.TabIndex = 4;
            this.ButtonCreateUser.Text = "Vytvoriť užívateľa";
            this.ButtonCreateUser.UseVisualStyleBackColor = true;
            this.ButtonCreateUser.Click += new System.EventHandler(this.ButtonCreateUser_Click);
            // 
            // UserCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 130);
            this.Controls.Add(this.ButtonCreateUser);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.TxtBoxPassword);
            this.Controls.Add(this.TxtBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserCreateForm";
            this.Text = "Vytvoriť užívateľa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox TxtBoxUsername;
        private System.Windows.Forms.TextBox TxtBoxPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonCreateUser;
    }
}