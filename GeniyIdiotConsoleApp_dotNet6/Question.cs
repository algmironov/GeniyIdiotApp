using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Answer { get; set; }

        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }


    }
}
