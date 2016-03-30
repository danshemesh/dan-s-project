using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dan_s_login_gui
{
    public partial class Dan_s_cloud_gui : Form
    {
        private string username;

        public Dan_s_cloud_gui(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }

        private void sendfiles_Click(object sender, EventArgs e)
        {
            savefile.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //private void browse2lock_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog filestosave = new OpenFileDialog();
        //    filestosave.ShowDialog();
        //    filestosave.InitialDirectory = @"C:\";
        //    filestosave.Title = "save Files";
        //    string filename = "";
        //    filename += filestosave.FileName;
        //    this.file_to_save = filename;
        //    filename = ChosenFileView.Text;
        //    ChosenFileView.Show();


        //    this.sock_obj.StartClient();
        //    this.sock_obj.Send("save");
        //}
    }
}
