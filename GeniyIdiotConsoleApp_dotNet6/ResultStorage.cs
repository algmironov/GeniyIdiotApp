using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp_dotNet6
{
    internal class ResultStorage
    {
       public static async void AddResult(Result result)
        {
            string filename = "results.txt";
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

            string fileName = "results.txt";
            try
            {
                result = await File.ReadAllTextAsync(fileName);
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
