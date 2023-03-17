using GeniyIdiotApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GeniyIdiotApp.Common
{
    public class DiagnosisStorage
    {
        public static HashSet<Diagnosis> diagnoses= new HashSet<Diagnosis>();
        static string filename = $@"{ Directory.GetCurrentDirectory()}/resources/diagnoses.json"; 
        

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

        internal static List<Diagnosis> FirstCall()
        {
            List<Diagnosis> diagnosis = new List<Diagnosis> 
            { 
            new Diagnosis("Кретин", -1, 17),
            new Diagnosis("Идиот", 16, 33),
            new Diagnosis("Дурак", 32, 64),
            new Diagnosis("Нормальынй", 63, 79),
            new Diagnosis("Талант", 78, 95),
            new Diagnosis("Гений", 94, 101)
            };
            return diagnosis;
        }

        private static void LoadAllDiagnoses()
        {
            var allDiagnoses = DataDealer.GetDataFromJson(filename);
            List<Diagnosis> diagnosesList = JsonSerializer.Deserialize<List<Diagnosis>>(allDiagnoses);
            diagnoses = diagnosesList.ToHashSet();
        }
    }
}
