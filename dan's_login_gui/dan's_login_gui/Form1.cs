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
    public partial class LoginandRegister : Form
    {
        public LoginandRegister()
        {
            InitializeComponent();
            CreateMyPasswordTextBox();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CreateMyPasswordTextBox()
        {
            // Create an instance of the TextBox control.

            // Set the maximum length of text in the control to eight.
            Passwordtextbox1.MaxLength = 14;
            PasswordtextBox2.MaxLength = 14;
            // Assign the asterisk to be the password character.
            Passwordtextbox1.PasswordChar = '*';
            PasswordtextBox2.PasswordChar = '*';
            // Change all text entered to be lowercase.
            Passwordtextbox1.CharacterCasing = CharacterCasing.Lower;
            PasswordtextBox2.CharacterCasing = CharacterCasing.Lower;
            // Align the text in the center of the TextBox control.
            Passwordtextbox1.TextAlign = HorizontalAlignment.Center;
            PasswordtextBox2.TextAlign = HorizontalAlignment.Center;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}

    

