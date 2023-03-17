using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GeniyIdiotApp.Common
{
    public class ResultStorage
    {
        static string filename = $@"{Directory.GetCurrentDirectory()}/resources/results.json";

        public static void AddResult(Result result)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            List<Result> resultList = GetListOfResults();
            resultList.Add(result);
            var data = JsonSerializer.Serialize<List<Result>>(resultList, options);
            DataDealer.SaveData(filename, data);
        }
        
        public static void PrintTableWithResults()
        {
            var results = GetListOfResults();
            Console.WriteLine("{0, -10} {1, -15} {2, 7}", "Имя", "Верных ответов", "Диагноз");
            foreach (var result in results)
            {
                Console.WriteLine("{0,-20} {1,-10} {2,-25}", result.Name, result.CorrectAnswersCount, result.Diagnosis);
            }

        }
        public static List<Result> GetListOfResults()
        {
            var resultsString = DataDealer.GetDataFromJson(filename);
            if (string.IsNullOrEmpty(resultsString))
            {
                return new List<Result>();
            }
            else
            {
                var results = JsonSerializer.Deserialize<List<Result>>(resultsString);
                return results;
            }
            
        }

        public static List<List<string>> GetAllResults()
        {
            List<string> preResults = new List<string>();
            List<List<string>> results = new List<List<string>>();
             var resultsString = DataDealer.GetDataFromJson(filename);
            if (!string.IsNullOrEmpty(resultsString))
            {
                var resultsList = JsonSerializer.Deserialize<List<Result>>(resultsString);
                
                foreach (var res in resultsList)
                {
                    List<string> elem =new List<string> { res.Name, res.CorrectAnswersCount.ToString(), res.Diagnosis };
                    results.Add(elem);
                }

                return results;
            }
            return results;
        }

        public static void ClearResults()
        {
            File.WriteAllText(filename, string.Empty);
        }

        public static void RemoveChoosenResult(Result result)
        {
            var results = GetListOfResults().Where(x =>!x.Equals(result)).ToList();
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize<List<Result>>(results, options);
            DataDealer.SaveData(filename, jsonString);
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
}
