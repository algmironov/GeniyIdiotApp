using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void EnterNameForm_Load(object sender, EventArgs e)
        {

        }

        private void sendNameButton_Click(object sender, EventArgs e)
        {
            Username = inputUsernameField.Text;
            PlayGameForm.Username = Username;
            this.Close();
        }

        private void EnterNameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsInputKey(Keys.Enter))
            {
                sendNameButton_Click(sender, e);
            }

        }
    }
}
