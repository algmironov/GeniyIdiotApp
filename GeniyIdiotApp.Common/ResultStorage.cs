using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotApp.Common
{
    public class ResultStorage
    {
       static string filename = $@"{Directory.GetCurrentDirectory()}/resources/results.txt";
        public static async void AddResult(Result result)
        {
            
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
        public static async void PrintTableWithResults()
        {
            string result = "";

            try
            {
                result = await File.ReadAllTextAsync(filename);
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

        public static List<List<string>> GetAllResults()
        {
            List<string> preResults = new List<string>();
            List<List<string>> results = new List<List<string>>();
             var resultsString = DataDealer.GetData(filename);
            if (!string.IsNullOrEmpty(resultsString))
            {
                preResults = resultsString.Remove(resultsString.Length - 2).Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var res in preResults)
                {
                    List<string> elem = res.Split(',').ToList();
                    results.Add(elem);
                }
                return results;
            }
            
            return results;
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
