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
            this.SignInbutton = new System.Windows.Forms.Button();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.loginpasswordlabel = new System.Windows.Forms.Label();
            this.loginusernamelabel = new System.Windows.Forms.Label();
            this.loginpassword = new System.Windows.Forms.TextBox();
            this.loginusername = new System.Windows.Forms.TextBox();
            this.RegisterTab = new System.Windows.Forms.TabPage();
            this.FolderCloudpicture = new System.Windows.Forms.PictureBox();
            this.Register = new System.Windows.Forms.Button();
            this.registerpassword = new System.Windows.Forms.TextBox();
            this.registerusername = new System.Windows.Forms.TextBox();
            this.registerpasslabel = new System.Windows.Forms.Label();
            this.registerusernamelabel = new System.Windows.Forms.Label();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.Cloudpicture);
            this.LoginTab.Controls.Add(this.SignInbutton);
            this.LoginTab.Controls.Add(this.Loginlabel);
            this.LoginTab.Controls.Add(this.loginpasswordlabel);
            this.LoginTab.Controls.Add(this.loginusernamelabel);
            this.LoginTab.Controls.Add(this.loginpassword);
            this.LoginTab.Controls.Add(this.loginusername);
            this.LoginTab.Location = new System.Drawing.Point(4, 25);
            this.LoginTab.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(4);
            this.LoginTab.Size = new System.Drawing.Size(543, 295);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
            // 
            // Cloudpicture
            // 
            this.Cloudpicture.Image = ((System.Drawing.Image)(resources.GetObject("Cloudpicture.Image")));
            this.Cloudpicture.Location = new System.Drawing.Point(357, 0);
            this.Cloudpicture.Margin = new System.Windows.Forms.Padding(4);
            this.Cloudpicture.Name = "Cloudpicture";
            this.Cloudpicture.Size = new System.Drawing.Size(183, 129);
            this.Cloudpicture.TabIndex = 6;
            this.Cloudpicture.TabStop = false;
            // 
            // SignInbutton
            // 
            this.SignInbutton.Location = new System.Drawing.Point(186, 222);
            this.SignInbutton.Margin = new System.Windows.Forms.Padding(4);
            this.SignInbutton.Name = "SignInbutton";
            this.SignInbutton.Size = new System.Drawing.Size(100, 28);
            this.SignInbutton.TabIndex = 5;
            this.SignInbutton.Text = "Sign In";
            this.SignInbutton.UseVisualStyleBackColor = true;
            this.SignInbutton.Click += new System.EventHandler(this.SignInbutton_Click);
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Loginlabel.Location = new System.Drawing.Point(200, 21);
            this.Loginlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(86, 33);
            this.Loginlabel.TabIndex = 4;
            this.Loginlabel.Text = "Login";
            this.Loginlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // loginpasswordlabel
            // 
            this.loginpasswordlabel.AutoSize = true;
            this.loginpasswordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginpasswordlabel.Location = new System.Drawing.Point(11, 158);
            this.loginpasswordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginpasswordlabel.Name = "loginpasswordlabel";
            this.loginpasswordlabel.Size = new System.Drawing.Size(112, 25);
            this.loginpasswordlabel.TabIndex = 3;
            this.loginpasswordlabel.Text = "Password:";
            // 
            // loginusernamelabel
            // 
            this.loginusernamelabel.AutoSize = true;
            this.loginusernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.loginusernamelabel.Location = new System.Drawing.Point(9, 85);
            this.loginusernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginusernamelabel.Name = "loginusernamelabel";
            this.loginusernamelabel.Size = new System.Drawing.Size(116, 25);
            this.loginusernamelabel.TabIndex = 2;
            this.loginusernamelabel.Text = "Username:";
            this.loginusernamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // loginpassword
            // 
            this.loginpassword.Location = new System.Drawing.Point(179, 158);
            this.loginpassword.Margin = new System.Windows.Forms.Padding(4);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(132, 22);
            this.loginpassword.TabIndex = 1;
            this.loginpassword.UseSystemPasswordChar = true;
            this.loginpassword.TextChanged += new System.EventHandler(this.Passwordtextbox1_TextChanged);
            // 
            // loginusername
            // 
            this.loginusername.Location = new System.Drawing.Point(179, 85);
            this.loginusername.Margin = new System.Windows.Forms.Padding(4);
            this.loginusername.Name = "loginusername";
            this.loginusername.Size = new System.Drawing.Size(132, 22);
            this.loginusername.TabIndex = 0;
            this.loginusername.TextChanged += new System.EventHandler(this.Usernametextbox1_TextChanged);
            // 
            // RegisterTab
            // 
            this.RegisterTab.Controls.Add(this.FolderCloudpicture);
            this.RegisterTab.Controls.Add(this.Register);
            this.RegisterTab.Controls.Add(this.registerpassword);
            this.RegisterTab.Controls.Add(this.registerusername);
            this.RegisterTab.Controls.Add(this.registerpasslabel);
            this.RegisterTab.Controls.Add(this.registerusernamelabel);
            this.RegisterTab.Controls.Add(this.Registerlabel);
            this.RegisterTab.Location = new System.Drawing.Point(4, 25);
            this.RegisterTab.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Padding = new System.Windows.Forms.Padding(4);
            this.RegisterTab.Size = new System.Drawing.Size(543, 295);
            this.RegisterTab.TabIndex = 1;
            this.RegisterTab.Text = "Register";
            this.RegisterTab.UseVisualStyleBackColor = true;
            // 
            // FolderCloudpicture
            // 
            this.FolderCloudpicture.Image = ((System.Drawing.Image)(resources.GetObject("FolderCloudpicture.Image")));
            this.FolderCloudpicture.Location = new System.Drawing.Point(359, 0);
            this.FolderCloudpicture.Margin = new System.Windows.Forms.Padding(4);
            this.FolderCloudpicture.Name = "FolderCloudpicture";
            this.FolderCloudpicture.Size = new System.Drawing.Size(181, 154);
            this.FolderCloudpicture.TabIndex = 11;
            this.FolderCloudpicture.TabStop = false;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(172, 233);
            this.Register.Margin = new System.Windows.Forms.Padding(4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 28);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // registerpassword
            // 
            this.registerpassword.Location = new System.Drawing.Point(153, 156);
            this.registerpassword.Margin = new System.Windows.Forms.Padding(4);
            this.registerpassword.Name = "registerpassword";
            this.registerpassword.Size = new System.Drawing.Size(132, 22);
            this.registerpassword.TabIndex = 9;
            this.registerpassword.UseSystemPasswordChar = true;
            // 
            // registerusername
            // 
            this.registerusername.Location = new System.Drawing.Point(153, 89);
            this.registerusername.Margin = new System.Windows.Forms.Padding(4);
            this.registerusername.Name = "registerusername";
            this.registerusername.Size = new System.Drawing.Size(132, 22);
            this.registerusername.TabIndex = 8;
            this.registerusername.TextChanged += new System.EventHandler(this.registerusername_TextChanged);
            // 
            // registerpasslabel
            // 
            this.registerpasslabel.AutoSize = true;
            this.registerpasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.registerpasslabel.Location = new System.Drawing.Point(9, 154);
            this.registerpasslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerpasslabel.Name = "registerpasslabel";
            this.registerpasslabel.Size = new System.Drawing.Size(112, 25);
            this.registerpasslabel.TabIndex = 7;
            this.registerpasslabel.Text = "Password:";
            // 
            // registerusernamelabel
            // 
            this.registerusernamelabel.AutoSize = true;
            this.registerusernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.registerusernamelabel.Location = new System.Drawing.Point(9, 89);
            this.registerusernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerusernamelabel.Name = "registerusernamelabel";
            this.registerusernamelabel.Size = new System.Drawing.Size(116, 25);
            this.registerusernamelabel.TabIndex = 6;
            this.registerusernamelabel.Text = "Username:";
            // 
            // Registerlabel
            // 
            this.Registerlabel.AutoSize = true;
            this.Registerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Registerlabel.Location = new System.Drawing.Point(165, 21);
            this.Registerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Registerlabel.Name = "Registerlabel";
            this.Registerlabel.Size = new System.Drawing.Size(124, 33);
            this.Registerlabel.TabIndex = 5;
            this.Registerlabel.Text = "Register";
            // 
            // LoginandRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 322);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginandRegister";
            this.Text = "Login and Register to dan\'s cloud";
            this.Load += new System.EventHandler(this.LoginandRegister_Load);
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
        private System.Windows.Forms.Label loginpasswordlabel;
        private System.Windows.Forms.Label loginusernamelabel;
        private System.Windows.Forms.TextBox loginpassword;
        private System.Windows.Forms.TextBox loginusername;
        private System.Windows.Forms.TabPage RegisterTab;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Button SignInbutton;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox registerpassword;
        private System.Windows.Forms.TextBox registerusername;
        private System.Windows.Forms.Label registerpasslabel;
        private System.Windows.Forms.Label registerusernamelabel;
        private System.Windows.Forms.Label Registerlabel;
        private System.Windows.Forms.PictureBox Cloudpicture;
        private System.Windows.Forms.PictureBox FolderCloudpicture;
    }
}

