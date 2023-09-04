namespace ChallengeApp
{
    public class Employee
    {

        private List<float> listOfPoints = new List<float>();

        public Employee(string name, string surname)
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
                Console.WriteLine($"Invalid value: {points} - out of range");
            }

        }

        public void AddPoints(double points)
        {
            float result = (float)points;
            this.AddPoints(result);
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
            else
            {
                Console.WriteLine($"Invalid value: {points} - not float");
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
            return statistics;
        }

    }
}
