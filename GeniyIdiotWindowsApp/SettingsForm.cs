using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class SettingsForm : Form
    {
        int timeForQuestion = Properties.GameSettings.Default.timeForOneQuestion;
        int questionCount = Properties.GameSettings.Default.inGameQuestionCount;
        public SettingsForm()
        {
            InitializeComponent();
            questionsCountTextBox.Text = questionCount.ToString();
            timeForQuestionTextBox.Text = timeForQuestion.ToString();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestionsForm deleteQuestionsForm = new DeleteQuestionsForm();
            deleteQuestionsForm.ShowDialog();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            addQuestion.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(timeForQuestionTextBox.Text) < 10)
                {
                    MessageBox.Show("Слишком мало времени на ответ!");
                }
                else if (int.Parse(timeForQuestionTextBox.Text) > 60)
                {
                    MessageBox.Show("Слишком долго для одного вопроса!");
                }
                else
                {
                    Properties.GameSettings.Default.timeForOneQuestion = int.Parse(timeForQuestionTextBox.Text);
                    Properties.GameSettings.Default.Save();
                }

                if (int.Parse(questionsCountTextBox.Text) < 2)
                {
                    MessageBox.Show("Не может быть меньше двух вопросов!");
                }
                else if (int.Parse(questionsCountTextBox.Text) > QuestionsStorage.getQuestions().Count)
                {
                    MessageBox.Show("Попробуйте ввести меньшее значение", "Слишком много вопросов!");
                }
                else
                {
                    Properties.GameSettings.Default.inGameQuestionCount = int.Parse(questionsCountTextBox.Text);
                    Properties.GameSettings.Default.Save();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Значение может быть только числом!", "Ошибка!");
                questionsCountTextBox.Text = Properties.GameSettings.Default.inGameQuestionCount.ToString();
                timeForQuestionTextBox.Text = Properties.GameSettings.Default.timeForOneQuestion.ToString();
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            questionsCountTextBox.Text = questionCount.ToString();
            timeForQuestionTextBox.Text = timeForQuestion.ToString();
        }

        private void questionsCountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(questionsCountTextBox.Text))
            {
                try
                {
                    int.Parse(questionsCountTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Значение может быть только числом!", "Ошибка!");
                    questionsCountTextBox.ResetText();
                }
            }


        }

        private void timeForQuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            int ignored;
            bool valid = int.TryParse(timeForQuestionTextBox.Text, out ignored);
            timeForQuestionTextBox.ForeColor = valid ? Color.Black : Color.Red;
        }
    }
}
