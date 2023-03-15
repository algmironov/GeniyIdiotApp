using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotApp.Common
{
    public class DataDealer
    {
        public static bool SaveData(string filename, string data)
        {
            if (File.Exists(filename))
            {
                StreamWriter writer = new StreamWriter(filename, true, Encoding.UTF8);
                writer.WriteLine(data);
                writer.Close();
                return true;
            }
            else
            {
                File.Create(filename).Close();
                StreamWriter writer = new StreamWriter(filename, true, Encoding.UTF8);
                writer.WriteLine(data);
                writer.Close();
                return true;
            }

        }

        public static string GetData(string filename)
        {
            if (File.Exists(filename))
            {
                StringBuilder sb = new StringBuilder();
                try
                {
                    StreamReader reader = new StreamReader(filename, Encoding.UTF8);
                    while (!reader.EndOfStream)
                    {
                        sb.Append(reader.ReadLine());
                        sb.Append("||");
                    }
                    reader.Close();
                }
                catch (IOException)
                {
                    return string.Empty;
                }
                return sb.ToString();
            }
            return string.Empty;
        }
        public static bool RemoveData(string filename, string data)
        {
            try
            {
                StreamReader reader = new StreamReader(filename, Encoding.UTF8);
                StringBuilder sb = new StringBuilder();
                while (!reader.EndOfStream)
                {
                    sb.Append(reader.ReadLine());
                    sb.Append("||");
                }
                reader.Close();
                string result = sb.ToString().Replace(data, "");
                var newData = result.Split("||", StringSplitOptions.RemoveEmptyEntries);
                File.WriteAllText(filename, string.Empty, Encoding.UTF8);
                File.AppendAllLines(filename, newData);
                return true;
            }
            catch (IOException)
            {
                Console.WriteLine("Error occured during deleting string");
                return false;
            }
        }

        public static async void PrepareFilesOnStart()
        {
            string resources = $@"{ Directory.GetCurrentDirectory()}/resources";
            if (!Directory.Exists(resources))
            {
                Directory.CreateDirectory(resources);
            }
            
            string diagnoses = $@"{resources}\diagnoses.txt";
            string questions = $@"{resources}\questions.txt";
            string results = $@"{resources}\results.txt";
            if (!File.Exists(diagnoses))
            {
                File.Create(diagnoses).Close();
                foreach (var diagnose in DiagnosisStorage.FirstCall())
                {
                    SaveData(diagnoses, diagnose);
                }
            }
            if (!File.Exists(questions))
            {
                File.Create(questions).Close();
               foreach (var q in QuestionsStorage.FirstCall())
                    {
                        SaveData(questions, q);
                    }
            }
            if (!File.Exists(results))
                {
                    File.Create(results).Close();
                }
        }



    }
}
