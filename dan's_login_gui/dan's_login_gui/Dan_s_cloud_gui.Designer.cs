namespace dan_s_login_gui
{
    partial class Dan_s_cloud_gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dan_s_cloud_gui));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.myfilestab = new System.Windows.Forms.TabPage();
            this.myfileslist = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.nameofiledel = new System.Windows.Forms.TextBox();
            this.delfile = new System.Windows.Forms.Button();
            this.pathtextbox = new System.Windows.Forms.TextBox();
            this.savefiles = new System.Windows.Forms.Button();
            this.sendfiles = new System.Windows.Forms.Button();
            this.sharedfilestab = new System.Windows.Forms.TabPage();
            this.savefile2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browse = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.myfilestab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.myfilestab);
            this.tabControl1.Controls.Add(this.sharedfilestab);
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // myfilestab
            // 
            this.myfilestab.Controls.Add(this.browse);
            this.myfilestab.Controls.Add(this.myfileslist);
            this.myfilestab.Controls.Add(this.button2);
            this.myfilestab.Controls.Add(this.nameofiledel);
            this.myfilestab.Controls.Add(this.delfile);
            this.myfilestab.Controls.Add(this.pathtextbox);
            this.myfilestab.Controls.Add(this.savefiles);
            this.myfilestab.Controls.Add(this.sendfiles);
            this.myfilestab.Location = new System.Drawing.Point(4, 25);
            this.myfilestab.Name = "myfilestab";
            this.myfilestab.Padding = new System.Windows.Forms.Padding(3);
            this.myfilestab.Size = new System.Drawing.Size(1303, 495);
            this.myfilestab.TabIndex = 0;
            this.myfilestab.Text = "myfiles";
            this.myfilestab.UseVisualStyleBackColor = true;
            // 
            // myfileslist
            // 
            this.myfileslist.Location = new System.Drawing.Point(17, 114);
            this.myfileslist.Name = "myfileslist";
            this.myfileslist.Size = new System.Drawing.Size(1276, 356);
            this.myfileslist.TabIndex = 7;
            this.myfileslist.UseCompatibleStateImageBehavior = false;
            this.myfileslist.SelectedIndexChanged += new System.EventHandler(this.myfileslist_SelectedIndexChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameofiledel
            // 
            this.nameofiledel.Location = new System.Drawing.Point(429, 18);
            this.nameofiledel.Name = "nameofiledel";
            this.nameofiledel.Size = new System.Drawing.Size(157, 22);
            this.nameofiledel.TabIndex = 3;
            this.nameofiledel.TextChanged += new System.EventHandler(this.nameofiledel_TextChanged);
            // 
            // delfile
            // 
            this.delfile.Location = new System.Drawing.Point(592, 14);
            this.delfile.Name = "delfile";
            this.delfile.Size = new System.Drawing.Size(157, 30);
            this.delfile.TabIndex = 2;
            this.delfile.Text = "delete file";
            this.delfile.UseVisualStyleBackColor = true;
            this.delfile.Click += new System.EventHandler(this.delfile_Click);
            // 
            // pathtextbox
            // 
            this.pathtextbox.Location = new System.Drawing.Point(123, 86);
            this.pathtextbox.Name = "pathtextbox";
            this.pathtextbox.Size = new System.Drawing.Size(322, 22);
            this.pathtextbox.TabIndex = 1;
            this.pathtextbox.TextChanged += new System.EventHandler(this.pathtextbox_TextChanged);
            // 
            // savefiles
            // 
            this.savefiles.Location = new System.Drawing.Point(1136, 6);
            this.savefiles.Name = "savefiles";
            this.savefiles.Size = new System.Drawing.Size(164, 30);
            this.savefiles.TabIndex = 1;
            this.savefiles.Text = "save files";
            this.savefiles.UseVisualStyleBackColor = true;
            this.savefiles.Click += new System.EventHandler(this.savefiles_Click);
            // 
            // sendfiles
            // 
            this.sendfiles.Location = new System.Drawing.Point(3, 3);
            this.sendfiles.Name = "sendfiles";
            this.sendfiles.Size = new System.Drawing.Size(164, 30);
            this.sendfiles.TabIndex = 0;
            this.sendfiles.Text = "share files";
            this.sendfiles.UseVisualStyleBackColor = true;
            this.sendfiles.Click += new System.EventHandler(this.sendfiles_Click);
            // 
            // sharedfilestab
            // 
            this.sharedfilestab.Location = new System.Drawing.Point(4, 25);
            this.sharedfilestab.Name = "sharedfilestab";
            this.sharedfilestab.Padding = new System.Windows.Forms.Padding(3);
            this.sharedfilestab.Size = new System.Drawing.Size(1303, 495);
            this.sharedfilestab.TabIndex = 1;
            this.sharedfilestab.Text = "sharedfiles";
            this.sharedfilestab.UseVisualStyleBackColor = true;
            // 
            // savefile2
            // 
            this.savefile2.FileName = "openFileDialog1";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(468, 86);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(82, 22);
            this.browse.TabIndex = 8;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Dan_s_cloud_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 522);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dan_s_cloud_gui";
            this.Text = "Dan_s_cloud_gui";
            this.tabControl1.ResumeLayout(false);
            this.myfilestab.ResumeLayout(false);
            this.myfilestab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage myfilestab;
        private System.Windows.Forms.Button sendfiles;
        private System.Windows.Forms.TabPage sharedfilestab;
        private System.Windows.Forms.Button savefiles;
        private System.Windows.Forms.TextBox pathtextbox;
        private System.Windows.Forms.OpenFileDialog savefile2;
        private System.Windows.Forms.TextBox nameofiledel;
        private System.Windows.Forms.Button delfile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView myfileslist;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browse;
    }
}