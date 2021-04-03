
namespace KMSMB
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonUserCreate = new System.Windows.Forms.Button();
            this.ButtonShareFolder = new System.Windows.Forms.Button();
            this.ButtonRemoveUser = new System.Windows.Forms.Button();
            this.LabelSMB1 = new System.Windows.Forms.Label();
            this.LabelSMB2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelIP = new System.Windows.Forms.Label();
            this.LabelSharedFolderName = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.nastaveniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stavSieteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveniaZdieľaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonUserCreate
            // 
            this.ButtonUserCreate.Location = new System.Drawing.Point(12, 199);
            this.ButtonUserCreate.Name = "ButtonUserCreate";
            this.ButtonUserCreate.Size = new System.Drawing.Size(140, 50);
            this.ButtonUserCreate.TabIndex = 0;
            this.ButtonUserCreate.Text = "Vytvoriť užívateľa";
            this.ButtonUserCreate.UseVisualStyleBackColor = true;
            this.ButtonUserCreate.Click += new System.EventHandler(this.ButtonUserCreate_Click);
            // 
            // ButtonShareFolder
            // 
            this.ButtonShareFolder.Location = new System.Drawing.Point(172, 199);
            this.ButtonShareFolder.Name = "ButtonShareFolder";
            this.ButtonShareFolder.Size = new System.Drawing.Size(140, 50);
            this.ButtonShareFolder.TabIndex = 1;
            this.ButtonShareFolder.Text = "Vyzdielať priečinok";
            this.ButtonShareFolder.UseVisualStyleBackColor = true;
            this.ButtonShareFolder.Click += new System.EventHandler(this.ButtonShareFolder_Click);
            // 
            // ButtonRemoveUser
            // 
            this.ButtonRemoveUser.Location = new System.Drawing.Point(332, 199);
            this.ButtonRemoveUser.Name = "ButtonRemoveUser";
            this.ButtonRemoveUser.Size = new System.Drawing.Size(140, 50);
            this.ButtonRemoveUser.TabIndex = 2;
            this.ButtonRemoveUser.Text = "Odstrániť užívateľa";
            this.ButtonRemoveUser.UseVisualStyleBackColor = true;
            this.ButtonRemoveUser.Click += new System.EventHandler(this.ButtonRemoveUser_Click);
            // 
            // LabelSMB1
            // 
            this.LabelSMB1.AutoSize = true;
            this.LabelSMB1.Location = new System.Drawing.Point(12, 33);
            this.LabelSMB1.Name = "LabelSMB1";
            this.LabelSMB1.Size = new System.Drawing.Size(36, 13);
            this.LabelSMB1.TabIndex = 4;
            this.LabelSMB1.Text = "SMB1";
            // 
            // LabelSMB2
            // 
            this.LabelSMB2.AutoSize = true;
            this.LabelSMB2.Location = new System.Drawing.Point(12, 52);
            this.LabelSMB2.Name = "LabelSMB2";
            this.LabelSMB2.Size = new System.Drawing.Size(36, 13);
            this.LabelSMB2.TabIndex = 5;
            this.LabelSMB2.Text = "SMB2";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label.Location = new System.Drawing.Point(12, 73);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(172, 16);
            this.Label.TabIndex = 6;
            this.Label.Text = "Údaje do web rozhrania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hostname/IP adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Názov zdieľaného priečinku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Užívateľské meno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Heslo:";
            // 
            // LabelIP
            // 
            this.LabelIP.AutoSize = true;
            this.LabelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelIP.Location = new System.Drawing.Point(191, 101);
            this.LabelIP.Name = "LabelIP";
            this.LabelIP.Size = new System.Drawing.Size(71, 13);
            this.LabelIP.TabIndex = 11;
            this.LabelIP.Text = "<neznáme>";
            // 
            // LabelSharedFolderName
            // 
            this.LabelSharedFolderName.AutoSize = true;
            this.LabelSharedFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSharedFolderName.Location = new System.Drawing.Point(191, 124);
            this.LabelSharedFolderName.Name = "LabelSharedFolderName";
            this.LabelSharedFolderName.Size = new System.Drawing.Size(71, 13);
            this.LabelSharedFolderName.TabIndex = 12;
            this.LabelSharedFolderName.Text = "<neznáme>";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelUsername.Location = new System.Drawing.Point(191, 147);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(71, 13);
            this.LabelUsername.TabIndex = 13;
            this.LabelUsername.Text = "<neznáme>";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelPassword.Location = new System.Drawing.Point(191, 170);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(71, 13);
            this.LabelPassword.TabIndex = 14;
            this.LabelPassword.Text = "<neznáme>";
            this.LabelPassword.Click += new System.EventHandler(this.LabelPassword_Click);
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("InfoPictureBox.Image")));
            this.InfoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("InfoPictureBox.InitialImage")));
            this.InfoPictureBox.Location = new System.Drawing.Point(160, 163);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(25, 25);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoPictureBox.TabIndex = 15;
            this.InfoPictureBox.TabStop = false;
            this.InfoPictureBox.Click += new System.EventHandler(this.InfoPictureBox_Click);
            this.InfoPictureBox.MouseHover += new System.EventHandler(this.InfoPictureBox_MouseHover);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveniaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "Menu";
            // 
            // nastaveniaToolStripMenuItem
            // 
            this.nastaveniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stavSieteToolStripMenuItem,
            this.nastaveniaZdieľaniaToolStripMenuItem});
            this.nastaveniaToolStripMenuItem.Name = "nastaveniaToolStripMenuItem";
            this.nastaveniaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.nastaveniaToolStripMenuItem.Text = "Nastavenia";
            // 
            // stavSieteToolStripMenuItem
            // 
            this.stavSieteToolStripMenuItem.Name = "stavSieteToolStripMenuItem";
            this.stavSieteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.stavSieteToolStripMenuItem.Text = "Stav siete";
            this.stavSieteToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_StavSiete_Item_Click);
            // 
            // nastaveniaZdieľaniaToolStripMenuItem
            // 
            this.nastaveniaZdieľaniaToolStripMenuItem.Name = "nastaveniaZdieľaniaToolStripMenuItem";
            this.nastaveniaZdieľaniaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nastaveniaZdieľaniaToolStripMenuItem.Text = "Nastavenia zdieľania";
            this.nastaveniaZdieľaniaToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_NastaveniaZdielania_Item_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.InfoPictureBox);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelSharedFolderName);
            this.Controls.Add(this.LabelIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LabelSMB2);
            this.Controls.Add(this.LabelSMB1);
            this.Controls.Add(this.ButtonRemoveUser);
            this.Controls.Add(this.ButtonShareFolder);
            this.Controls.Add(this.ButtonUserCreate);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "KM SMB";
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button ButtonUserCreate;
        private System.Windows.Forms.Button ButtonShareFolder;
        private System.Windows.Forms.Button ButtonRemoveUser;
        private System.Windows.Forms.Label LabelSMB1;
        private System.Windows.Forms.Label LabelSMB2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelIP;
        private System.Windows.Forms.Label LabelSharedFolderName;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem nastaveniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stavSieteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveniaZdieľaniaToolStripMenuItem;
    }
}

