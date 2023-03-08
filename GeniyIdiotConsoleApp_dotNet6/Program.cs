using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;




namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            QuestionsStorage.addQuestion(new Question("Сколько будет два плюс два умноженное на два?",  6));
            QuestionsStorage.addQuestion(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",  9));
            QuestionsStorage.addQuestion(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?",  25));
            QuestionsStorage.addQuestion(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",  60));
            QuestionsStorage.addQuestion(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",  2));

            DiagnosisStorage.AddDiagnosis(new Diagnosis("кретин", 0, 17));
            DiagnosisStorage.AddDiagnosis(new Diagnosis("идиот", 16, 33));
            DiagnosisStorage.AddDiagnosis(new Diagnosis("дурак", 32, 64));
            DiagnosisStorage.AddDiagnosis(new Diagnosis("нормальный", 63, 79));
            DiagnosisStorage.AddDiagnosis(new Diagnosis("талант", 78, 95));
            DiagnosisStorage.AddDiagnosis(new Diagnosis("гений", 94, 100));

            List<Question> questions = QuestionsStorage.getQuestions();
            int questionsCount = questions.Count;

            Random random = new Random();

            string username = "";
            bool nameIsEmpty = true;
            while (nameIsEmpty)
            {
                Console.WriteLine("Введите Ваше имя: ");
                username = Console.ReadLine();
                if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
                {
                    Console.WriteLine("Имя не может быть пустым!  ");
                }
                else
                {
                    nameIsEmpty = false;
                }
            }

            bool userAgreedToContinue = true;

            while (userAgreedToContinue)
            {
                int correctAnswersCount = 0;
                List<string> askedQuestions = new List<string>();
                for (int i = 0; i < questionsCount; i++)
                {
                    Console.WriteLine("Вопрос №" + (i + 1));

                    int randomQuestionIndex = random.Next(0, questionsCount);
                    string question = questions.ElementAt(randomQuestionIndex).Text;

                    while (askedQuestions.Contains(question))
                    {
                        randomQuestionIndex = random.Next(0, questionsCount);
                        question = questions.ElementAt(randomQuestionIndex).Text;
                    }
                    Console.WriteLine(question);
                    askedQuestions.Add(question);
                    int userAnswer = 0;
                    bool answerAccepted = false;

                    while (!answerAccepted)
                    {
                        try
                        {
                            userAnswer = int.Parse(Console.ReadLine());
                            answerAccepted = true;
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("Ответ должен быть в виде числа! \nПопробуйте еще раз");
                            Console.WriteLine(question);
                        }

                    }
                    int correctAnswer = questions.ElementAt(randomQuestionIndex).Answer;

                    if (userAnswer == correctAnswer)
                    {
                        correctAnswersCount++;
                    }
                }
                Console.WriteLine(username + ", " + "Ваш диагноз: " + DiagnosisStorage.GetDiagnosisByResult(correctAnswersCount));
                Result result = new Result(username, correctAnswersCount, DiagnosisStorage.GetDiagnosisByResult(correctAnswersCount));
                
                ResultStorage.AddResult(result);
                ResultStorage.PrintTableWithResults();
               
                Console.WriteLine("Хотите пройти заново? Y/N");

                string userAgreement = Console.ReadLine().ToUpper();
                if (userAgreement.Equals("N"))
                {
                    userAgreedToContinue = false;
                }
                
            }
        }
 
        
        
    }
}