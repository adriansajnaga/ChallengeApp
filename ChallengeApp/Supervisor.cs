namespace ChallengeApp
{
    public class Supervisor : iEmployee
    {
        private List<float> listOfPoints = new List<float>();

        public Supervisor()
        {
            this.Name = "Adrian";
            this.Surname = "Sajnaga";
        }

        public Supervisor(string name, string surname)
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
            throw new NotImplementedException();
        }

        public void AddPoints(char points)
        {
            throw new NotImplementedException();
        }

        public void AddPoints(long points)
        {
            throw new NotImplementedException();
        }

        public void AddPoints(int points)
        {
            float result = points;
            this.AddPoints(result);
        }

        public void AddPoints(string points)
        {

            switch (points)
            {
                case "6":
                    this.AddPoints(100);
                    break;
                case "-6":
                case "6-":
                    this.AddPoints(95);
                    break;
                case "+5":
                case "5+":
                    this.AddPoints(85);
                    break;
                case "5":
                    this.AddPoints(80);
                    break;
                case "-5":
                case "5-":
                    this.AddPoints(75);
                    break;
                case "+4":
                case "4+":
                    this.AddPoints(65);
                    break;
                case "4":
                    this.AddPoints(60);
                    break;
                case "-4":
                case "4-":
                    this.AddPoints(55);
                    break;
                case "+3":
                case "3+":
                    this.AddPoints(45);
                    break;
                case "3":
                    this.AddPoints(40);
                    break;
                case "-3":
                case "3-":
                    this.AddPoints(35);
                    break;
                case "+2":
                case "2+":
                    this.AddPoints(25);
                    break;
                case "2":
                    this.AddPoints(20);
                    break;
                case "-2":
                case "2-":
                    this.AddPoints(15);
                    break;
                case "+1":
                case "1+":
                    this.AddPoints(5);
                    break;
                case "-1":
                case "1":
                case "1-":
                    this.AddPoints(0);
                    break;
                default:
            throw new Exception($"Invalid letter: {points}");
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


