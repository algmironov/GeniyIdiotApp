using GeniyIdiotApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotApp.Common
{
    public class DiagnosisStorage
    {
        public static HashSet<Diagnosis> diagnoses= new HashSet<Diagnosis>();
        static string filename = $@"{ Directory.GetCurrentDirectory()}/resources/diagnoses.txt"; 
        

        public static void AddDiagnosis(Diagnosis diagnosis)
        {
            diagnoses.Add(diagnosis);
        }

        public static string GetDiagnosisByResult(int correctAnswersCount, int questionsCount)
        {
            LoadAllDiagnoses();
            int correctAnswersPercentage = (correctAnswersCount * 100) / questionsCount ;
            foreach (var diagnosis in diagnoses)
            {
                if (correctAnswersPercentage > diagnosis.Min && correctAnswersPercentage < diagnosis.Max)
                {
                    return diagnosis.UserDiagnosis;
                }
            }
            return "";
        }

        internal static List<string> FirstCall()
        {
            List<string> diagnoses = new List<string>();
            diagnoses.Add("Кретин, 0, 17");
            diagnoses.Add("Идиот,16,33");
            diagnoses.Add("Дурак,32,64");
            diagnoses.Add("Нормальный,63,79");
            diagnoses.Add("Талант,78,95");
            diagnoses.Add("Гений,94,101");
           return diagnoses;
            
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
