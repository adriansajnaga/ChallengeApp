namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> listOfPoints = new List<float>();

        public override event PointAddedDelegate PointAdded;

        public EmployeeInMemory(string name, string surname)
        :base(name, surname)
        {
        }

        public override void AddPoints(float points)
        {
            if (points >= 0 && points <= 100)
            {
                this.listOfPoints.Add(points);

                if (PointAdded != null)
                {
                    PointAdded(this, new EventArgs());
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

