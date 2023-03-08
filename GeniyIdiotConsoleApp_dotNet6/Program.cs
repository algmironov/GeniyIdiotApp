﻿using System.Runtime.Serialization;
using System;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int questionsCount = 5;

            Random random = new Random();

            string username = "";
            bool nameIsEmpty = true;
            while (nameIsEmpty)
            {
                Console.WriteLine("Введите Ваше имя: ");
                username = Console.ReadLine();
                if (string.IsNullOrEmpty(username))
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
                    string question = GetQuestios(questionsCount)[randomQuestionIndex];
                    while (askedQuestions.Contains(question))
                    {
                        randomQuestionIndex = random.Next(0, questionsCount);
                        question = GetQuestios(questionsCount)[randomQuestionIndex];
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
                    int correctAnswer = GetAnswers(questionsCount)[randomQuestionIndex];

                    if (userAnswer == correctAnswer)
                    {
                        correctAnswersCount++;
                    }
                }
                Console.WriteLine(username + ", " + "Ваш диагноз: " + GetDiagnoses(correctAnswersCount, questionsCount));
                Result result = new Result(username, correctAnswersCount, GetDiagnoses(correctAnswersCount, questionsCount));
               
                Console.WriteLine("Хотите пройти заново? Y/N");

                string userAgreement = Console.ReadLine().ToUpper();
                if (userAgreement.Equals("N"))
                {
                    userAgreedToContinue = false;
                }
                AddResult(result);
                PrintTableWithResults();
            }
        }

        public static String[] GetQuestios(int count)
        {
            string[] questions = new string[count];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?";
            questions[4] = "Пять свечей горело, две потухли. Сколько свечей осталось?";
            return questions;
        }

        public static int[] GetAnswers(int count)
        {
            int[] answers = new int[count];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;
            return answers;
        }

        public static string GetDiagnoses(int rightAnswersCount, int questionsCount)
        {
            int correctAnswersPercent = (rightAnswersCount * 100) / questionsCount;
            string diagnosis = "";
            string[] diagnoses = new string[6];
            diagnoses[0] = "кретин";
            diagnoses[1] = "идиот";
            diagnoses[2] = "дурак";
            diagnoses[3] = "нормальный";
            diagnoses[4] = "талант";
            diagnoses[5] = "гений";

            if (correctAnswersPercent < 17)
            {
                diagnosis = diagnoses[0];
            }
            if (correctAnswersPercent > 16 && correctAnswersPercent < 33)
            {
                diagnosis = diagnoses[1];
            }
            if (correctAnswersPercent > 32 && correctAnswersPercent < 64)
            {
                diagnosis = diagnoses[2];
            }
            if (correctAnswersPercent > 63 && correctAnswersPercent < 79)
            {
                diagnosis = diagnoses[3];
            }
            if (correctAnswersPercent > 78 && correctAnswersPercent < 95)
            {
                diagnosis = diagnoses[4];
            }
            if (correctAnswersPercent > 94)
            {
                diagnosis = diagnoses[5];
            }
            return diagnosis;
        }

        static async void AddResult(Result result)
        {
            string filename = "results.txt";
            string data = $"{result.Name},{result.CorrectAnswersCount},{result.Diagnosis};";
            if (File.Exists(filename))
            {
                try
                {
                    await File.AppendAllTextAsync(filename, data);
                }
                catch (IOException)
                {
                    Console.WriteLine("Couldn't write your result to file");
                }
            }
            else
            {
                File.Create(filename).Close();
            }
        }
        static async void PrintTableWithResults()
        {
            string result = "";
            
            string fileName = "results.txt";
            try
            {
                result = await File.ReadAllTextAsync(fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("There are no results");
            }
            string[] resultsArray = result.Split(";", StringSplitOptions.RemoveEmptyEntries);
            int longestString = resultsArray.Max(x => x.Length);
            foreach (var res in resultsArray)
            {
                string[] data = res.Split(",");
                Result resultToPrint = new Result(data[0], int.Parse(data[1]), data[2]);
                Console.WriteLine(resultToPrint.ToString());
                
                Console.WriteLine(PrintTableLine(longestString));
            }
        }
        static string PrintTableLine(int length)
        {
            int size = length + 8;
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                line.Append("-");
            }
            return line.ToString();
        }
        
    }
    [Serializable]
    public class Result
    {
        public string Name { get; set; } = "Unknown";
        public int CorrectAnswersCount { get; set; } = -1;
        public string Diagnosis { get; set; } = "Unknown";

        public Result(string name, int answersCount, string diagnosis)
        {
            Name = name;
            CorrectAnswersCount = answersCount;
            Diagnosis = diagnosis;
        }

        public Result()
        {

        }

        public override string ToString()
        {
            return $"{Name} || {CorrectAnswersCount} || {Diagnosis}";
        }
    }
}