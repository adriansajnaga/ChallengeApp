namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "points.txt";

        public EmployeeInFile(string name, string surname)
        : base(name, surname)
        {
        }

        public override void AddPoints(float points)
        {
            if (points >= 0 && points <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(points);
                }
            }
            else
            {
                throw new Exception($"Invalid value: {points} - out of range");
            }
        }

        public override void AddPoints(string points)
        {

            if (float.TryParse(points, out float result))
            {
                this.AddPoints(result);
            }
            else if (char.TryParse(points, out char charresult))
            {
                this.AddPoints(charresult);
            }
            else
            {
                throw new Exception($"Invalid value: {points} - not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;
            int count = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                { 
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        float.TryParse(line, out float point);
                        statistics.Max = Math.Max(statistics.Max, point);
                        statistics.Min = Math.Min(statistics.Min, point);
                        statistics.Avg += point;
                        count++;
                    }
                }
            }
            else
            {
                throw new Exception($"The File: {fileName} - not exist");
            }

            statistics.Avg /= count;
            statistics.Count = count;
            switch (statistics.Avg)
            {
                case var a when a > 80:
                    statistics.AvgLetter = 'A';
                    break;
                case var a when a > 60:
                    statistics.AvgLetter = 'B';
                    break;
                case var a when a > 40:
                    statistics.AvgLetter = 'C';
                    break;
                case var a when a > 20:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    statistics.AvgLetter = 'E';
                    break;
            }
            return statistics;

        }
    }
}


