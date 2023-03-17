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
    public partial class showWrongAnswersForm : Form
    {
        public showWrongAnswersForm()
        {
            InitializeComponent();
            drawList();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drawList()
        {

            listBox1.BeginUpdate();
            foreach (var item in PlayGameForm.wrongAnswers)
            {
                listBox1.Items.Add($"{item.Key.Text} | Вы ответили: {item.Value} | Правильный ответ: {item.Key.Answer}");
            }
            listBox1.EndUpdate();
        }
    }
}
