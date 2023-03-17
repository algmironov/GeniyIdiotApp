using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWindowsApp
{
    public partial class EnterNameForm : Form
    {
        public static string Username { get; set; }
        public EnterNameForm()
        {
            InitializeComponent();
            inputUsernameField.Select();
        }

        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }

        private void sendNameButton_Click(object sender, EventArgs e)
        {
            Username = inputUsernameField.Text;
            if (string.IsNullOrEmpty(Username.Trim()))
            {
                MessageBox.Show("Имя не может быть пустым!");
            }
            else
            {
                PlayGameForm.Username = Username;
                this.Close();
            }
            
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            PlayGameForm.IsNameEntered = false;
            this.Close();
        }
    }
}
