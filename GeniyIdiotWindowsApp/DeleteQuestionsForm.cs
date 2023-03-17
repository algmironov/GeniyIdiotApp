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

namespace GeniyIdiotWindowsApp
{
    public partial class DeleteQuestionsForm : Form
    {
        HashSet<Question> allQuestions = QuestionsStorage.getQuestions();
        public DeleteQuestionsForm()
        {
            InitializeComponent();
        }

        private void DeleteQuestionsForm_Load(object sender, EventArgs e)
        {
            questionsList.BeginUpdate();
            foreach (Question question in allQuestions)
            {
                questionsList.Items.Add(question.Text);
            }
            questionsList.EndUpdate();
            questionsList.Show();
            questionsList.CheckOnClick = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            List<string> checkedQuestions = new();
            var checkedQuestionsCount = questionsList.CheckedItems.Count;

            if (checkedQuestionsCount > 0)
            {
                DialogResult res = MessageBox.Show("Удалить выбранные вопросы?", $"Вы выбрали {checkedQuestionsCount} {spellingQuestionsNumberEnd(checkedQuestionsCount)}", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    questionsList.BeginUpdate();
                    checkedQuestions = questionsList.CheckedItems.Cast<string>().ToList();

                    foreach (var element in checkedQuestions)
                    {
                        foreach (var questionToRemove in allQuestions)
                        {
                            if (element.Equals(questionToRemove.Text))
                            {
                                QuestionsStorage.RemoveQuestion(questionToRemove);
                                allQuestions.Remove(questionToRemove);

                                questionsList.Items.Remove(questionToRemove.Text);

                            }
                        }
                    }
                    questionsList.EndUpdate();
                    questionsList.Show();
                }
                else if (res == DialogResult.No)
                {
                    int index = 0;
                    questionsList.BeginUpdate();
                    foreach (var element in checkedQuestions)
                    {
                        questionsList.SetItemChecked(index++, false);
                    }
                    questionsList.EndUpdate();
                    questionsList.Show();
                }
            }

        }

        private string spellingQuestionsNumberEnd(int count)
        {
            int element = 0;
            if (count < 10)
            {
                element = count;
            }
            else if (count < 100 && count > 10)
            {
                element = count % 10;
            }

            string word = "";
            switch (element)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    word = "вопросов";
                    break;
                case 1:
                    word = "вопрос";
                    break;
                case 2:
                case 3:
                case 4:
                    word = "вопроса";
                    break;
            }
            return word;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
