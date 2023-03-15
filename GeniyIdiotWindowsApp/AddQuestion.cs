using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeniyIdiotApp.Common;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeniyIdiotWindowsApp
{
    public partial class AddQuestion : Form
    {
        public AddQuestion()
        {
            InitializeComponent();
            {
                System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                toolTip.AutoPopDelay = 5000;
                toolTip.InitialDelay = 1000;
                toolTip.ReshowDelay = 500;

                toolTip.ShowAlways = true;
                toolTip.SetToolTip(this.inputAnswerLabel, "Ответ должен быть числом!");
            }
        }

        private void inputAnswerLabel_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Ответ должен быть числом!");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            questionTextBox.Clear();
            answerTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            string text = questionTextBox.Text;
            int answer;
            var textNotAccepted = true;
            var answerNotAccepted = true;

            if (text.Length < 2 || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Вопрос не может быть пустым или состоять из одного символа!");
            }
            else
            {
                question.Text = text;
                textNotAccepted = false;
            }

            try
            {
                answer = int.Parse(answerTextBox.Text);
                question.Answer = answer;
                answerNotAccepted = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ответ должен быть целым числом!","Неверный формат ответа!");
            }

            if (!textNotAccepted && !answerNotAccepted)
            {
                QuestionsStorage.addQuestion(question);
                questionTextBox.Clear();
                answerTextBox.Clear();
                DialogResult res = MessageBox.Show("Хотите добавить еще один вопрос?", "Вопрос сохранен", MessageBoxButtons.YesNo);
                if (res == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
