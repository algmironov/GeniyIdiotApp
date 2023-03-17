using GeniyIdiotApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeniyIdiotApp.Common
{
    public class QuestionsStorage
    {
        static HashSet<Question> questions = new HashSet<Question>();
        static Dictionary<int, Question> questionsList = new Dictionary<int, Question>();
        static string filename = $@"{Directory.GetCurrentDirectory()}/resources/questions.json";

        public static void addQuestion(Question question)
        {
            questions.Add(question);
            var options = new JsonSerializerOptions { WriteIndented = true };
            var questionsJson = DataDealer.GetDataFromJson(filename);
            var questionsList = JsonSerializer.Deserialize<List<Question>>(questionsJson);
            questionsList.Add(question);
            questionsJson = JsonSerializer.Serialize(questionsList, options);
            _ = DataDealer.SaveData(filename, questionsJson);
        }

        public static void RemoveQuestion(Question question)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var questionsJson = DataDealer.GetDataFromJson(filename);
            var questionsList = JsonSerializer.Deserialize<List<Question>>(questionsJson);
            questionsList.Remove(question);
            questions.Remove(question);
            questionsJson = JsonSerializer.Serialize(questionsList, options);
            DataDealer.SaveData(filename, questionsJson);
        }

        public static HashSet<Question> getQuestions()
        {
            LoadQuestionsList();
            return questions;
        }

        private static void LoadQuestionsList()
        {
            questions.Clear();
            string query = DataDealer.GetDataFromJson(filename);
            var allQuestions =JsonSerializer.Deserialize<List<Question>>(query);
            foreach (var question in allQuestions)
            {
                questions.Add(question);
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
                    RemoveQuestion(questionToDelete);
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

        internal static List<Question> FirstCall()
        {
            return new List<Question> { 
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2),
            new Question("Сколько башен в Московском Кремле?", 20),
            new Question("Сколько в одном байте бит?" , 8),
            new Question("Сколько в одном Терабайте Гигабайт?", 1024),
            new Question("В каком году Ю. А. Гагарин впервые полетел в Космос?", 1961),
            new Question("Сколько колес в легковом автомобиле?", 6),
            new Question("Сколько в одном килограмме грамм?", 1000)
            };  
        }
    }
}
