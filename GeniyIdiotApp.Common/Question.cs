using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotApp.Common
{
    public class Question
    {
        public string Text { get; set; }
        public int Answer { get; set; }

        public Question()
        {
        }
        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }

       

    }
}
