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

    public partial class PlayGameForm : Form
    {
        private List<Question> questions = QuestionsStorage.getQuestions().ToList();
        private List<string> answeredQuestions = new List<string>();
        Result result = new Result();
        public static string Username { get; set; }
        private int questionNumber = 1;
        Random random = new Random();
        Question? question;

        public PlayGameForm()
        {
            InitializeComponent();
            EnterNameForm enterNameForm = new EnterNameForm();
            enterNameForm.ShowDialog();
            result.Name = Username;
            questionNumberText.Text = $"Итак, {Username}, вопрос номер {questionNumber}";
            question = getRandomQuestion();
            questionTextField.Text = question.Text;
            progressBar1.ForeColor = Color.BlueViolet;
            progressBar1.Step = 100 / questions.Count();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendAnswerButton_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
            {
                string diagnosis = DiagnosisStorage.GetDiagnosisByResult(result.CorrectAnswersCount, answeredQuestions.Count);
                result.Diagnosis = diagnosis;
                MessageBox.Show($"Ваш диагноз: {result.Diagnosis}");
                ResultStorage.AddResult(result);
                this.Close();
            }
            else
            {
                progressBar1.PerformStep();
                try
                {
                    if (question.Answer == int.Parse(textBox1.Text))
                    {
                        result.CorrectAnswersCount++;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ответ должен быть в виде числа!");
                }
                question = getRandomQuestion();
                questionNumber++;
                questionTextField.Text = question.Text;
                textBox1.Text = string.Empty;
                questionNumberText.Text = $"Итак, {Username}, вопрос номер {questionNumber}";
            }
        }

        private Question getRandomQuestion()
        {
            int randomIndex = random.Next(0, questions.Count);
            question = questions[randomIndex];
            
            answeredQuestions.Add(question.Text);
            questions.Remove(question);
            return question;
        }
    }
}
