using System;
using System.Threading;
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
        public string IP = "127.0.0.1";
        public int PORT = 1238;
        SOCKETHANDLER client = new SOCKETHANDLER();
        public LoginandRegister()
        {
            InitializeComponent();
            client.Connect(IP, PORT);
            
        }
        private void LoginandRegister_Load(object sender, EventArgs e)
        {

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
        
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignInbutton_Click(object sender, EventArgs e)
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
                //עובד! להוריד הערה בסוף השיעור
                string username = loginusername.Text;
                string password = loginpassword.Text;
                client.Send("login");
                client.Recv(1024);
                client.Send(username);
                client.Recv(1024); 
                //MessageBox.Show(username);
                client.Send(password);
                string result = client.RecvStr(1024);
               
                MessageBox.Show(result.ToString());
                MessageBox.Show(result.Length.ToString());
                //לסדר את בעיית ההתחברות לא עובד!
                if (result == "login good")
                {
                    Dan_s_cloud_gui form = new Dan_s_cloud_gui(username, client);
                    MessageBox.Show("hello " + username + " you are now signd in");
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("not good try again");

                }
                //Dan_s_cloud_gui form = new Dan_s_cloud_gui("roi", client);
                //form.Show();
                //MessageBox.Show("hello" + roi + " you are now signd in");
                //הכנסה ידנית למחוק לאחר סידור פעולת ההתחברות
                //Dan_s_cloud_gui form2 = new Dan_s_cloud_gui("ronnie",client);
                //form2.Show();

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
            client.Send("register");
            client.Recv(1024);
            client.Send(registerusername.Text);
            client.Recv(1024);
            Thread.Sleep(1000);
            client.Send(registerpassword.Text);
            registerusername.Text = "";
            registerpassword.Text = "";
            MessageBox.Show("thank you for registering please login");

        }

        private void registerusername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

    

