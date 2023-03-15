namespace GeniyIdiotApp.Common
{
    [Serializable]
    public class Result
    {
        public int Id { get; set; }
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
            return $"{Name} || {CorrectAnswersCount} || {Diagnosis}";
        }
    }
}