
namespace KMSMB
{
    partial class ShareFolderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShareFolderForm));
            this.UserList = new System.Windows.Forms.ListBox();
            this.ButtonSelectUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(12, 12);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(230, 160);
            this.UserList.TabIndex = 0;
            // 
            // ButtonSelectUser
            // 
            this.ButtonSelectUser.Location = new System.Drawing.Point(12, 182);
            this.ButtonSelectUser.Name = "ButtonSelectUser";
            this.ButtonSelectUser.Size = new System.Drawing.Size(230, 37);
            this.ButtonSelectUser.TabIndex = 1;
            this.ButtonSelectUser.Text = "Vybrať užívateľa";
            this.ButtonSelectUser.UseVisualStyleBackColor = true;
            this.ButtonSelectUser.Click += new System.EventHandler(this.ButtonSelectUser_Click);
            // 
            // ShareFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 231);
            this.Controls.Add(this.ButtonSelectUser);
            this.Controls.Add(this.UserList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShareFolderForm";
            this.Text = "Zdieľanie priečinku";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Button ButtonSelectUser;
    }
}