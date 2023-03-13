using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class DiagnosisStorage
    {
        public static HashSet<Diagnosis> diagnoses= new HashSet<Diagnosis>();
        static string filename = "diagnoses.txt";

        public static void AddDiagnosis(Diagnosis diagnosis)
        {
            diagnoses.Add(diagnosis);
        }

        public static string GetDiagnosisByResult(int correctAnswersCount)
        {
            LoadAllDiagnoses();

            foreach (var diagnosis in diagnoses)
            {
                if (correctAnswersCount > diagnosis.Min && correctAnswersCount < diagnosis.Max)
                {
                    return diagnosis.UserDiagnosis;
                }
            }
            return "";
        }

        private static void LoadAllDiagnoses()
        {
            string[] allDiagnoses = DataDealer.GetData(filename).Split("||", StringSplitOptions.RemoveEmptyEntries);
            foreach (var str in allDiagnoses)
            {
                string[] diag = str.Split(",");
                Diagnosis diagnosis = new Diagnosis(diag[0], int.Parse(diag[1]), int.Parse(diag[2]));
                diagnoses.Add(diagnosis);
            }
        }
    }
}
