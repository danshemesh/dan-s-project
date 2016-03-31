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
        private string pathtofileupload;
        private SOCKETHANDLER client;
        public Dan_s_cloud_gui(string username,SOCKETHANDLER client)
        {
            InitializeComponent();
            this.username = username;
            this.client = client;
            
        }

        private void sendfiles_Click(object sender, EventArgs e)
        {
            
        }


        private void savefiles_Click(object sender, EventArgs e)
        {
            //OpenFileDialog savefile2 = new OpenFileDialog();
            //if(savefile2.ShowDialog() == DialogResult.OK)
            //{
            //    pathtextbox.Text = savefile2.SelectedPath;
            //}
            OpenFileDialog savefile2 = new OpenFileDialog();
            client.Send("uploadfiles");
            string msg = client.RecvStr(1024);
            savefile2.ShowDialog();
            savefile2.InitialDirectory = @"C:\";
            savefile2.Title = "save files";
            string filename = "";
            filename += savefile2.FileName;
            this.pathtofileupload = filename;
            //client.Send("uploadfiles");
            client.Send(username);
            client.Recv(1024);
            client.Send(pathtofileupload);
            MessageBox.Show("your file has been uploaded to dan's cloud thank you!");
        }

        private void delfile_Click(object sender, EventArgs e)
        {
            client.Send("deletfile");
            string msg = client.RecvStr(1024);
            string name = nameofiledel.Text;
            client.Send(username);
            client.Recv(1024);
            client.Send(name);
            MessageBox.Show("your file has been deleted");
        }

        private void nameofiledel_TextChanged(object sender, EventArgs e)
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
