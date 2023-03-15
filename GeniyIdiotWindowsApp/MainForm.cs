using System.Diagnostics;

using GeniyIdiotApp.Common;

namespace GeniyIdiotWindowsApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            PlayGameForm f2 = new PlayGameForm();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void getResultsButton_Click(object sender, EventArgs e)
        {
            if (ResultStorage.GetAllResults().Count == 0)
            {
                MessageBox.Show("Пока нет результатов для просмотра!");
            }
            else
            {
                resultsTable1 resultsTable = new resultsTable1();
                this.Hide();
                resultsTable.ShowDialog();
                this.Show();
            }

        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            AddQuestion addQuestion = new AddQuestion();
            this.Hide();
            addQuestion.ShowDialog();
            this.Show();
        }

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestionsForm deleteQuestionsForm = new DeleteQuestionsForm();
            this.Hide();
            deleteQuestionsForm.ShowDialog();
            this.Show();
        }
    }
}