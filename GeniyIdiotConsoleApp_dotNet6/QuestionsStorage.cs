using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class QuestionsStorage
    {
        static List<Question> questions = new List<Question>();

        public static void addQuestion(Question question)
        {
            questions.Add(question);
        }

        public static void removeQuestion(Question question)
        {
            questions.Remove(question);
        }

        public static List<Question> getQuestions()
        {
            return questions;
        }

        public static List<int> getAnswers()
        { 
            return questions.Select(x => x.Answer).ToList();
        }

    }
}
