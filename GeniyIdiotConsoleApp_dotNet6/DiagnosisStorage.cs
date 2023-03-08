using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class DiagnosisStorage
    {
        public static List<Diagnosis> diagnoses= new List<Diagnosis>();

        public static void AddDiagnosis(Diagnosis diagnosis)
        {
            diagnoses.Add(diagnosis);
        }

        public static string GetDiagnosisByResult(int correctAnswersCount)
        {
            foreach (var diagnosis in diagnoses)
            {
                if (correctAnswersCount > diagnosis.Min && correctAnswersCount < diagnosis.Max)
                {
                    return diagnosis.UserDiagnosis;
                }
            }
            return "";
        }
    }
}
