using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class Diagnosis
    {
        public string UserDiagnosis { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public Diagnosis(string userDiagnosis, int min, int max)
        {
            UserDiagnosis = userDiagnosis;
            Min = min;
            Max = max;
        }
    }
}
