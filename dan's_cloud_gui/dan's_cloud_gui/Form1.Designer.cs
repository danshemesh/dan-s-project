namespace dan_s_cloud_gui
{
    partial class Cloud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cloud));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MyFiles = new System.Windows.Forms.TabPage();
            this.SharedFiles = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.MyFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MyFiles);
            this.tabControl1.Controls.Add(this.SharedFiles);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(856, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // MyFiles
            // 
            this.MyFiles.Controls.Add(this.label1);
            this.MyFiles.Location = new System.Drawing.Point(4, 22);
            this.MyFiles.Name = "MyFiles";
            this.MyFiles.Padding = new System.Windows.Forms.Padding(3);
            this.MyFiles.Size = new System.Drawing.Size(848, 342);
            this.MyFiles.TabIndex = 0;
            this.MyFiles.Text = "MyFiles";
            this.MyFiles.UseVisualStyleBackColor = true;
            // 
            // SharedFiles
            // 
            this.SharedFiles.Location = new System.Drawing.Point(4, 22);
            this.SharedFiles.Name = "SharedFiles";
            this.SharedFiles.Padding = new System.Windows.Forms.Padding(3);
            this.SharedFiles.Size = new System.Drawing.Size(848, 342);
            this.SharedFiles.TabIndex = 1;
            this.SharedFiles.Text = "SharedFiles";
            this.SharedFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(120, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome to dan\'s cloud here you can reach your files";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(854, 383);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cloud";
            this.Text = "dan\'s cloud";
            this.tabControl1.ResumeLayout(false);
            this.MyFiles.ResumeLayout(false);
            this.MyFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MyFiles;
        private System.Windows.Forms.TabPage SharedFiles;
        private System.Windows.Forms.Label label1;
    }
}

