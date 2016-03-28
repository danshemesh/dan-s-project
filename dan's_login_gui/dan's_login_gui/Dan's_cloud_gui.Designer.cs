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
            this.savefiles = new System.Windows.Forms.Button();
            this.sendfiles = new System.Windows.Forms.Button();
            this.sharedfilestab = new System.Windows.Forms.TabPage();
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
            // savefiles
            // 
            this.savefiles.Location = new System.Drawing.Point(1136, 6);
            this.savefiles.Name = "savefiles";
            this.savefiles.Size = new System.Drawing.Size(164, 30);
            this.savefiles.TabIndex = 1;
            this.savefiles.Text = "save files";
            this.savefiles.UseVisualStyleBackColor = true;
            // 
            // sendfiles
            // 
            this.sendfiles.Location = new System.Drawing.Point(3, 3);
            this.sendfiles.Name = "sendfiles";
            this.sendfiles.Size = new System.Drawing.Size(164, 30);
            this.sendfiles.TabIndex = 0;
            this.sendfiles.Text = "share files";
            this.sendfiles.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage myfilestab;
        private System.Windows.Forms.Button sendfiles;
        private System.Windows.Forms.TabPage sharedfilestab;
        private System.Windows.Forms.Button savefiles;
    }
}