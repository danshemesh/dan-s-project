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
        private string my_uid;
        private string my_fname;
        private string my_lname;
        private string file_to_save;
        private List<string> uid_list = new List<string>();
        private string to_send;
        public SocketClient sock_obj;
        public Dan_s_cloud_gui(string user_info)
        {
            InitializeComponent();
            this.my_uid = user_info.Split('#')[0];
            this.my_fname = user_info.Split('#')[1];
            this.my_lname = user_info.Split('#')[2];

            SocketClient sock_obj = new SocketClient();
            this.sock_obj = sock_obj;
            sendfiles.Enabled = false;
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
