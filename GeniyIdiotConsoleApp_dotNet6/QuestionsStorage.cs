using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class QuestionsStorage
    {
        static HashSet<Question> questions = new HashSet<Question>();
        static Dictionary<int, Question> questionsList = new Dictionary<int, Question>();
        static string filename = "questions.txt";

        public static void addQuestion(Question question)
        {
            questions.Add(question);
            _ = DataDealer.SaveData("questions.txt", question.Text + "#" + question.Answer);
        }

        public static void removeQuestion(Question question)
        {
            if(DataDealer.RemoveData("questions.txt", question.Text + "#" + question.Answer))
            {
                questions.Remove(question);
            }
   
        }

        public static HashSet<Question> getQuestions()
        {
            LoadQuestionsList();
            return questions;
        }

        private static void LoadQuestionsList()
        {
            string query = DataDealer.GetData(filename);
            var allQuestions = query.Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var question in allQuestions)
            {
                var questionAndAnswer = question.Split("#");
                questions.Add(new Question(questionAndAnswer[0], int.Parse(questionAndAnswer[1])));
            }
        }

        public static void AddNewQuestion()
        {
            var addingNewQuestions = true;
            var inputIncorrect = true;
            var newQuestion = "";
            int newAnswer = 0;
            while (addingNewQuestions)
            {
                Console.WriteLine("Введите текст нового вопроса: ");
                newQuestion = Console.ReadLine();
                Console.WriteLine("Введите ответ в виде числа:");

                while (inputIncorrect)
                {
                    try
                    {
                        newAnswer = int.Parse(Console.ReadLine());
                        inputIncorrect = false;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Ответ не является число, попробуйте еще раз:");
                    }
                }
                Question question = new Question(newQuestion, newAnswer);
                addQuestion(question);
                Console.WriteLine("Вопрос успешно добавлен!");
                Console.WriteLine("Хотите добавить еще один вопрос?\nВведите ДА или НЕТ");
                var yesNoAccepted = true;
                while (yesNoAccepted)
                {
                   var wishToContinue = Console.ReadLine().ToUpper();
                    if (wishToContinue.Equals("НЕТ"))
                    {
                        addingNewQuestions = false;
                        yesNoAccepted = false; 
                    }
                }
            }

        }

        public static void DeleteQuestion()
        {
            var deletingQuestion = true;
           
            PrintQuestionsListToDelete();
            while (deletingQuestion)
            {
                var wishToContinueDeleting = true;
                Console.WriteLine("Введите номер вопроса, который хотите удалить: ");
                try
                {
                    int questionPosition = int.Parse(Console.ReadLine());
                    Question questionToDelete = questionsList.GetValueOrDefault(questionPosition);
                    removeQuestion(questionToDelete);
                    questionsList.Clear();
                    questions.Clear();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Произошла ошибка, введите корректный номер вопроса!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы ввели некорректный номер, попробуйте еще раз!");
                 }
                

                while (wishToContinueDeleting)
                {
                    deletingQuestion = false;
                    Console.WriteLine("Хотите удалить еще один вопрос?\nВведите Да/Нет");
                    string answer = Console.ReadLine().ToLower();
                    if (answer.Equals("нет") || answer.Equals("да")){
                        if (answer.Equals("нет"))
                        {
                            wishToContinueDeleting = false;
                            deletingQuestion = false;
                        }
                        else
                        {
                            deletingQuestion= true;
                            wishToContinueDeleting = false;
                            PrintQuestionsListToDelete();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введите только ДА или НЕТ!");
                    }
                    
                }
            }
        }

        private static void PrintQuestionsListToDelete()
        {
            int position = 1;
            if(questions.Count == 0)
            {
                LoadQuestionsList();
            }
            
            foreach (var question in questions)
            {
                questionsList.Add(position, question);
                Console.WriteLine($"{position}) {question.Text}");
                position++;
            }
        }
    }
}
