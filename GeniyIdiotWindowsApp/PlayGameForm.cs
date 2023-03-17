using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

using GeniyIdiotApp.Common;

namespace GeniyIdiotWindowsApp
{
    
    public partial class PlayGameForm : Form
    {
        public static bool IsNameEntered { get; set; } = true;
        private List<Question> questions = LoadQuestions();
        private List<string> answeredQuestions = new List<string>();
        Result result = new Result();
        public static string Username { get; set; }
        private int questionNumber = 1;
        Random random = new Random();
        Question? question;
        int timeLeft = Properties.GameSettings.Default.timeForOneQuestion;

        public PlayGameForm()
        {
            InitializeComponent();
            EnterNameForm enterNameForm = new EnterNameForm();
            enterNameForm.ShowDialog();
            if (!IsNameEntered)
            {
                this.Close();
            }
            result.Name = Username;
            questionNumberText.Text = $"Итак, {Username}, вопрос номер {questionNumber}";
            question = getRandomQuestion();
            questionTextField.Text = question.Text;
            progressBar1.ForeColor = Color.BlueViolet;
            progressBar1.Step = 100 / questions.Count();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            answerInputTextBox.Select();
            sendAnswerButton.Text = $"Отправить ({timeLeft.ToString()} {secondsSpelling(timeLeft)})";
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timeLeft--;

            sendAnswerButton.Text = $"Отправить ({timeLeft.ToString()} {secondsSpelling(timeLeft)})";
            if (timeLeft == 0)
            {
                timer.Stop();
                sendAnswerButton_Click(sender, new EventArgs());
            }
        }
        private static List<Question> LoadQuestions()
        {
            var questions = QuestionsStorage.getQuestions().ToList();
            if (questions.Count < Properties.GameSettings.Default.inGameQuestionCount)
            {
                var toRemoveFromList = Properties.GameSettings.Default.inGameQuestionCount - questions.Count;
                Random random = new Random();
                for (int i = 0; i < toRemoveFromList; i++)
                {
                    var index = random.Next(questions.Count - 1);
                    questions.RemoveAt(index);
                }
                return questions;
            }
            return questions;
        }

        private void sendAnswerButton_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
            {
                timer.Stop();
                string diagnosis = DiagnosisStorage.GetDiagnosisByResult(result.CorrectAnswersCount, answeredQuestions.Count);
                result.Diagnosis = diagnosis;
                MessageBox.Show($"{result.Name}, Ваш диагноз: {result.Diagnosis}", "Игра завершена!");
                ResultStorage.AddResult(result);
                this.Close();
            }
            else
            {
                progressBar1.PerformStep();
                if (!string.IsNullOrEmpty(answerInputTextBox.Text))
                {
                    try
                    {
                        if (question.Answer == int.Parse(answerInputTextBox.Text))
                        {
                            result.CorrectAnswersCount++;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Ответ должен быть в виде числа!");
                    }
                }

                question = getRandomQuestion();
                questionNumber++;
                questionTextField.Text = question.Text;
                answerInputTextBox.Text = string.Empty;
                questionNumberText.Text = $"Итак, {Username}, вопрос номер {questionNumber}";
                timeLeft = Properties.GameSettings.Default.timeForOneQuestion;
                answerInputTextBox.Select();
                timer.Start();
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

        private string secondsSpelling(int num)
        {
            string seconds = "";
            switch (num)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    seconds = "секунд";
                    break;
                case 1:
                    seconds = "секунда";
                    break;
                case 2:
                case 3:
                case 4:
                    seconds = "секунды";
                    break;
            }
            return seconds;
        }
    }
}
