namespace dan_s_login_gui
{
    partial class LoginandRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginandRegister));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.Cloudpicture = new System.Windows.Forms.PictureBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Passwordlabel1 = new System.Windows.Forms.Label();
            this.Usernamelabel1 = new System.Windows.Forms.Label();
            this.Passwordtextbox1 = new System.Windows.Forms.TextBox();
            this.Usernametextbox1 = new System.Windows.Forms.TextBox();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.FolderCloudpicture = new System.Windows.Forms.PictureBox();
            this.Register = new System.Windows.Forms.Button();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.UsernametextBox2 = new System.Windows.Forms.TextBox();
            this.Passwordlabel2 = new System.Windows.Forms.Label();
            this.Usernamelabel2 = new System.Windows.Forms.Label();
            this.Registerlabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.LoginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cloudpicture)).BeginInit();
            this.RegisterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderCloudpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.LoginTab);
            this.tabControl1.Controls.Add(this.RegisterTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 263);
            this.tabControl1.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.Cloudpicture);
            this.LoginTab.Controls.Add(this.SignIn);
            this.LoginTab.Controls.Add(this.Loginlabel);
            this.LoginTab.Controls.Add(this.Passwordlabel1);
            this.LoginTab.Controls.Add(this.Usernamelabel1);
            this.LoginTab.Controls.Add(this.Passwordtextbox1);
            this.LoginTab.Controls.Add(this.Usernametextbox1);
            this.LoginTab.Location = new System.Drawing.Point(4, 22);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(405, 237);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // Cloudpicture
            // 
            this.Cloudpicture.Image = ((System.Drawing.Image)(resources.GetObject("Cloudpicture.Image")));
            this.Cloudpicture.Location = new System.Drawing.Point(268, 0);
            this.Cloudpicture.Name = "Cloudpicture";
            this.Cloudpicture.Size = new System.Drawing.Size(137, 105);
            this.Cloudpicture.TabIndex = 6;
            this.Cloudpicture.TabStop = false;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(148, 179);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(75, 23);
            this.SignIn.TabIndex = 5;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Loginlabel.Location = new System.Drawing.Point(150, 17);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(73, 29);
            this.Loginlabel.TabIndex = 4;
            this.Loginlabel.Text = "Login";
            this.Loginlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Passwordlabel1
            // 
            this.Passwordlabel1.AutoSize = true;
            this.Passwordlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Passwordlabel1.Location = new System.Drawing.Point(8, 128);
            this.Passwordlabel1.Name = "Passwordlabel1";
            this.Passwordlabel1.Size = new System.Drawing.Size(88, 20);
            this.Passwordlabel1.TabIndex = 3;
            this.Passwordlabel1.Text = "Password:";
            // 
            // Usernamelabel1
            // 
            this.Usernamelabel1.AutoSize = true;
            this.Usernamelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Usernamelabel1.Location = new System.Drawing.Point(7, 69);
            this.Usernamelabel1.Name = "Usernamelabel1";
            this.Usernamelabel1.Size = new System.Drawing.Size(91, 20);
            this.Usernamelabel1.TabIndex = 2;
            this.Usernamelabel1.Text = "Username:";
            this.Usernamelabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwordtextbox1
            // 
            this.Passwordtextbox1.Location = new System.Drawing.Point(134, 128);
            this.Passwordtextbox1.Name = "Passwordtextbox1";
            this.Passwordtextbox1.Size = new System.Drawing.Size(100, 20);
            this.Passwordtextbox1.TabIndex = 1;
            // 
            // Usernametextbox1
            // 
            this.Usernametextbox1.Location = new System.Drawing.Point(134, 69);
            this.Usernametextbox1.Name = "Usernametextbox1";
            this.Usernametextbox1.Size = new System.Drawing.Size(100, 20);
            this.Usernametextbox1.TabIndex = 0;
            // 
            // RegisterTab
            // 
            this.RegisterTab.Controls.Add(this.FolderCloudpicture);
            this.RegisterTab.Controls.Add(this.Register);
            this.RegisterTab.Controls.Add(this.PasswordtextBox2);
            this.RegisterTab.Controls.Add(this.UsernametextBox2);
            this.RegisterTab.Controls.Add(this.Passwordlabel2);
            this.RegisterTab.Controls.Add(this.Usernamelabel2);
            this.RegisterTab.Controls.Add(this.Registerlabel);
            this.RegisterTab.Location = new System.Drawing.Point(4, 22);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTab.Size = new System.Drawing.Size(405, 237);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            this.RegisterTab.UseVisualStyleBackColor = true;
            // 
            // FolderCloudpicture
            // 
            this.FolderCloudpicture.Image = ((System.Drawing.Image)(resources.GetObject("FolderCloudpicture.Image")));
            this.FolderCloudpicture.Location = new System.Drawing.Point(269, 0);
            this.FolderCloudpicture.Name = "FolderCloudpicture";
            this.FolderCloudpicture.Size = new System.Drawing.Size(136, 125);
            this.FolderCloudpicture.TabIndex = 11;
            this.FolderCloudpicture.TabStop = false;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(129, 189);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(115, 127);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox2.TabIndex = 9;
            // 
            // UsernametextBox2
            // 
            this.UsernametextBox2.Location = new System.Drawing.Point(115, 72);
            this.UsernametextBox2.Name = "UsernametextBox2";
            this.UsernametextBox2.Size = new System.Drawing.Size(100, 20);
            this.UsernametextBox2.TabIndex = 8;
            // 
            // Passwordlabel2
            // 
            this.Passwordlabel2.AutoSize = true;
            this.Passwordlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Passwordlabel2.Location = new System.Drawing.Point(7, 125);
            this.Passwordlabel2.Name = "Passwordlabel2";
            this.Passwordlabel2.Size = new System.Drawing.Size(88, 20);
            this.Passwordlabel2.TabIndex = 7;
            this.Passwordlabel2.Text = "Password:";
            // 
            // Usernamelabel2
            // 
            this.Usernamelabel2.AutoSize = true;
            this.Usernamelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Usernamelabel2.Location = new System.Drawing.Point(7, 72);
            this.Usernamelabel2.Name = "Usernamelabel2";
            this.Usernamelabel2.Size = new System.Drawing.Size(91, 20);
            this.Usernamelabel2.TabIndex = 6;
            this.Usernamelabel2.Text = "Username:";
            // 
            // Registerlabel
            // 
            this.Registerlabel.AutoSize = true;
            this.Registerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Registerlabel.Location = new System.Drawing.Point(124, 17);
            this.Registerlabel.Name = "Registerlabel";
            this.Registerlabel.Size = new System.Drawing.Size(104, 29);
            this.Registerlabel.TabIndex = 5;
            this.Registerlabel.Text = "Register";
            // 
            // LoginandRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginandRegister";
            this.Text = "Login and Register to dan\'s cloud";
            this.tabControl1.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cloudpicture)).EndInit();
            this.RegisterTab.ResumeLayout(false);
            this.RegisterTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderCloudpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.Label Passwordlabel1;
        private System.Windows.Forms.Label Usernamelabel1;
        private System.Windows.Forms.TextBox Passwordtextbox1;
        private System.Windows.Forms.TextBox Usernametextbox1;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.TextBox UsernametextBox2;
        private System.Windows.Forms.Label Passwordlabel2;
        private System.Windows.Forms.Label Usernamelabel2;
        private System.Windows.Forms.Label Registerlabel;
        private System.Windows.Forms.PictureBox Cloudpicture;
        private System.Windows.Forms.PictureBox FolderCloudpicture;
    }
}

