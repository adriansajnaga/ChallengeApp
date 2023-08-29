namespace ChallengeApp
{
    public class Employee                                           //KLASA
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
            this.listOfPoints.Add(points);
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
