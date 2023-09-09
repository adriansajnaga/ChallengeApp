namespace ChallengeApp
{
    public class Worker : iEmployee
    { 
        private List<float> listOfPoints = new List<float>();

        public Worker()
        {
            this.Name = "Adrian";
            this.Surname = "Sajnaga";
        }

        public Worker(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddPoints(float points)
        {
            if (points >= 0 && points <= 100)
            {
                this.listOfPoints.Add(points);
            }
            else
            {
                throw new Exception($"Invalid value: {points} - out of range");
            }
        }

        public void AddPoints(double points)
        {
            float result = (float)points;
            this.AddPoints(result);
        }

        public void AddPoints(char points)
        {
            switch (points)
            {
                case 'a':
                case 'A':
                    this.AddPoints(100);
                    break;
                case 'b':
                case 'B':
                    this.AddPoints(80);
                    break;
                case 'c':
                case 'C':
                    this.AddPoints(60);
                    break;
                case 'd':
                case 'D':
                    this.AddPoints(40);
                    break;
                case 'e':
                case 'E':
                    this.AddPoints(20);
                    break;
                default:
                    throw new Exception($"Invalid letter: {points}");
            }
        }

        public void AddPoints(long points)
        {
            float result = Convert.ToSingle(points);
            this.AddPoints(result);
        }

        public void AddPoints(int points)
        {
            float result = points;
            this.AddPoints(result);
        }

        public void AddPoints(string points)
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Avg = 0;

            foreach (var point in this.listOfPoints)
            {
                statistics.Max = Math.Max(statistics.Max, point);
                statistics.Min = Math.Min(statistics.Min, point);
                statistics.Avg += point;
            }
            statistics.Avg /= this.listOfPoints.Count;
            statistics.Count = this.listOfPoints.Count;
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
