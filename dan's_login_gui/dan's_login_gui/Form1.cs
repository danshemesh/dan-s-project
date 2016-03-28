using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;

namespace dan_s_login_gui
{
    public partial class LoginandRegister : Form
    {
        public string reuname ;
        public string regpass;
        public string lastname;
        public SocketClient sock_obj;
        public LoginandRegister()
        {
            InitializeComponent();
            //CreateMyPasswordTextBox();
            SocketClient sock_obj = new SocketClient();
            this.sock_obj = sock_obj;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public void CreateMyPasswordTextBox()
        //{
        //    // Create an instance of the TextBox control.

        //    // Set the maximum length of text in the control to eight.
        //    Passwordtextbox1.MaxLength = 14;
        //    PasswordtextBox2.MaxLength = 14;
        //    // Assign the asterisk to be the password character.
        //    Passwordtextbox1.PasswordChar = '*';
        //    PasswordtextBox2.PasswordChar = '*';
        //    // Change all text entered to be lowercase.
        //    Passwordtextbox1.CharacterCasing = CharacterCasing.Lower;
        //    PasswordtextBox2.CharacterCasing = CharacterCasing.Lower;
        //    // Align the text in the center of the TextBox control.
        //    Passwordtextbox1.TextAlign = HorizontalAlignment.Center;
        //    PasswordtextBox2.TextAlign = HorizontalAlignment.Center;
        //}
        //private void Register()
        //{
        //    // Open the named pipe.
        //    var server = new NamedPipeServerStream("connect");

        //    Console.WriteLine("Waiting for connection...");
        //    server.WaitForConnection();

        //    Console.WriteLine("Connected.");
        //    var br = new BinaryReader(server);
        //    var bw = new BinaryWriter(server);

        //    while (true)
        //    {
        //        try
        //        {
        //            var len = (int)br.ReadUInt32();            // Read string length
        //            var str = new string(br.ReadChars(len));    // Read string

        //            Console.WriteLine("Read: \"{0}\"", str);

        //            str = new string(str.Reverse().ToArray());  // Just for fun

        //            var buf = Encoding.ASCII.GetBytes(str);     // Get ASCII byte array     
        //            bw.Write((uint)buf.Length);                // Write string length
        //            bw.Write(buf);                              // Write string
        //            Console.WriteLine("Wrote: \"{0}\"", str);
        //        }
        //        catch (EndOfStreamException)
        //        {
        //            break;                    // When client disconnects
        //        }
        //    }

        //    Console.WriteLine("Client disconnected.");
        //    server.Close();
        //    server.Dispose();
        //}
        private void UserSignIn(string username, string password)
        {
            if (username == "")
            {
                MessageBox.Show("Please enter username");
                this.Show();
            }
            else if (password == "")
            {
                MessageBox.Show("Please enter password");
                this.Show();
            }
            else
            {

                //string hashed_password = sha256(password);
                //send username and password to python and checks if correct
                string info = "login#" + username + "#" + password;


                this.sock_obj.StartClient();
                this.sock_obj.Send(info);
                string message_to_split = this.sock_obj.Recv();
                string message = message_to_split.Split('#')[0];
                //if (message_to_split.Split('#')[1] != "0")
                //{
                //    this.my_uid = message_to_split.Split('#')[2];
                //    this.firstname = message_to_split.Split('#')[1];
                //    this.lastname = message_to_split.Split('#')[3];
                //    //MessageBox.Show(my_uid + firstname + lastname);
                //}
                //sock_obj.CloseClient();

                //if receives true then send the user to the next gui.
                if (message == "Signed in")
                {
                    string user_info = this.loginusername.Text + "#" + this.loginpassword.Text;
                    Dan_s_cloud_gui form = new Dan_s_cloud_gui(user_info);
                    form.Show();
                }
                else
                {

                    MessageBox.Show("incorrect password or username");
                    this.Show();
                }



            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginusername.Text == "")
            {
                MessageBox.Show("Please enter username");
                this.Show();
            }
            else if (loginpassword.Text == "")
            {
                MessageBox.Show("Please enter password");
                this.Show();
            }
            else
            {

                //string hashed_password = sha256(password);
                //send username and password to python and checks if correct
                string info = "login#" + loginusername + "#" + loginpassword;


                this.sock_obj.StartClient();
                this.sock_obj.Send(info);
                string message_to_split = this.sock_obj.Recv();
                string message = message_to_split.Split('#')[0];
                if (message_to_split.Split('#')[1] != "0")
                {
                    this.loginusername.Text = message_to_split.Split('#')[2];
                    this.loginpassword.Text = message_to_split.Split('#')[1];
                    this.lastname = message_to_split.Split('#')[3];
                    //MessageBox.Show(my_uid + firstname + lastname);
                }
                sock_obj.CloseClient();

                //if receives true then send the user to the next gui.
                if (message == "Signed in")
                {
                    string user_info = this.loginusername + "#" + this.loginpassword;
                    Dan_s_cloud_gui form = new Dan_s_cloud_gui(user_info);
                    form.Show();
                }
                else
                {

                    MessageBox.Show("incorrect password or username");
                    this.Show();
                }



            }
        
    }

        private void Usernametextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Passwordtextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

            string regu = registerusername.Text;
            string regpass = registerpassword.Text;
            string info = "register#" + regu + "#" + regpass;
            this.sock_obj.StartClient();
            this.sock_obj.Send(info);

            string message = this.sock_obj.Recv();
            if (message == "registerd")
            {
                MessageBox.Show("got registerd, hello "+regu+"!");
            }
            


            this.sock_obj.CloseClient();
        }

        private void LoginandRegister_Load(object sender, EventArgs e)
        {

        }
    }
}

    

