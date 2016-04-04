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
        private string myfiles;
        private string[] lmyfiles;

        public Dan_s_cloud_gui(string username,SOCKETHANDLER client)
        {
            InitializeComponent();
            button2.Hide();
            this.username = username;
            this.client = client;
            client.Send(username);
            this.myfiles = client.RecvStr(1024);
            Console.WriteLine(this.myfiles);
            this.lmyfiles = myfiles.Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            client.Recv(1024);
            initListView();
            managemyfiles(this.lmyfiles);
            
            
        }
        private void managemyfiles(string[] myfiles)
        {
            //int size = myfiles.Count();
            //int i = 0;
            //for (i = 0; i <= size; i = i + 1)
            //{
            //    myfileslist.Items.Add(this.myfiles[i]);
            //}
            //myfileslist.SelectionMode = SelectionMode.MultiSimple;
            

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

        private void myfileslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Dan_s_cloud_gui_Load(object sender, EventArgs e)
        {
            //string[] array = { "cat", "dog", "mouse" };
            //var items = myfileslist.Items;
            //foreach (var value in lmyfiles)
            //{
            //    items.Add(value);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Send("downloadfile");
            client.Recv(1024);
            string path = pathtextbox.Text;
            string filename = myfileslist.SelectedItems[0].Text;
            string pathefile = path + "@" + filename+"@"+username;
            client.Send(pathefile);
            client.Recv(1024);
            
            //foreach (Object obj in myfileslist.SelectedItems)
            //{
            //    MessageBox.Show(obj.ToString());
            //}


        }

        private void myfileslist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //var selectedItems = myfileslist.SelectedItems;
            //if (selectedItems.Count > 0)
            //{
            //    // Display text of first item selected.
            //    this.Text = selectedItems[0].Text;
            //}
            //else
            //{
            //    // Display default string.
            //    this.Text = "Empty";
            //}
            //MessageBox.Show("You clicked " + myfileslist.SelectedItems[0].Text);
        }
        private void initListView()
        {
            // Add columnsImage
            ImageList ilist = new ImageList();
            this.myfileslist.LargeImageList = ilist;

            myfileslist.Columns.Add("file name", -2, HorizontalAlignment.Left);
            int size = this.lmyfiles.Count();
            int i = 0;
            for (i = 0; i <= size-1; i = i + 1)
            {
                var item1 = new ListViewItem(new[] {lmyfiles[i] });
                myfileslist.Items.Add(item1);
                
            }
           
            

        }

        private void pathtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathtextbox.Text = folderBrowserDialog1.SelectedPath;
            }
            button2.Show();
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
