using System.Text;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            var inMenu = true;
            var inGame = false;
            var addingQuestion = false;
            var deletingQuestion = false;
            var watchingResults = false;
            int menuPoint = 0;

            while(inMenu)
            {
                var menuIsAccepted = false;
                Console.WriteLine("Добро пожаловать в игру Гений или идиот!\n1. Играть\n2. Смотреть результаты\n3. Добавить вопросы\n4. Удалить вопросы\n\nВведите номер пункта меню для продолжения:");

                while (!menuIsAccepted)
                {
                    var menuInput = Console.ReadLine();
                    try
                    {
                        menuPoint = int.Parse(menuInput);
                        menuIsAccepted = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Ответ должен быть в виде числа! \nПопробуйте еще раз");
                    }
                }

                if (menuPoint == 1)
                {
                    inGame = true;
                    while (inGame)
                    {
                        inMenu = false;
                        StartGame();
                        inMenu= true;
                        inGame= false;
                    }
                }
               else  if (menuPoint == 2)
                {
                    watchingResults = true;
                    while (watchingResults)
                    {
                        inMenu = false;
                        ResultStorage.PrintTableWithResults();
                        inMenu = true;
                        watchingResults= false;
                    }

                }
                else if (menuPoint == 3)
                {
                    QuestionsStorage.AddNewQuestion();
                }
                else  if (menuPoint == 4)
                {
                    QuestionsStorage.DeleteQuestion();
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильное число, повторите ввод!");
                        //todo logic
                 }
            }
         }

          static void StartGame()
         {
            HashSet<Question> questions = QuestionsStorage.getQuestions();
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
                    Question questionToAsk = questions.ElementAt(randomQuestionIndex);
                    string question = questionToAsk.Text;

                    while (askedQuestions.Contains(question))
                    {
                        randomQuestionIndex = random.Next(0, questionsCount);
                        questionToAsk = questions.ElementAt(randomQuestionIndex);
                        question = questionToAsk.Text;
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
                    int correctAnswer = questionToAsk.Answer;

                    if (userAnswer == correctAnswer)
                    {
                        correctAnswersCount++;
                    }
                }
                int resultPersentage = (correctAnswersCount * 100 )/ askedQuestions.Count;
                string userDiagnosis = DiagnosisStorage.GetDiagnosisByResult(resultPersentage);
                Console.WriteLine(username + ", " + "Ваш диагноз: " + userDiagnosis);
                Result result = new Result(username, correctAnswersCount, userDiagnosis);

                ResultStorage.AddResult(result);

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