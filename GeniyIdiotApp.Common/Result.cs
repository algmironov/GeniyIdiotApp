﻿namespace GeniyIdiotApp.Common
{
    [Serializable]
    public class Result
    {
        public string Name { get; set; } = "Unknown";
        public int CorrectAnswersCount { get; set; } = 0;
        public string Diagnosis { get; set; } = "Unknown";

        public Result(string name, int answersCount, string diagnosis)
        {
            Name = name;
            CorrectAnswersCount = answersCount;
            Diagnosis = diagnosis;
        }

        public Result()
        {

        }

        public override string ToString()
        {
            return $"{Name},{CorrectAnswersCount} ,{Diagnosis}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType())
                return false;
            Result other = obj as Result;

            return Name.Equals(other.Name) && CorrectAnswersCount == other.CorrectAnswersCount && Diagnosis.Equals(other.Diagnosis);
        }
    }
}