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
            if (PlayGameForm.IsNameEntered)
            {
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                f2.Close();
                PlayGameForm.IsNameEntered = true;
            }

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

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            this.Hide();
            settingsForm.ShowDialog();
            this.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}