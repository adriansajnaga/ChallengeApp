namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "points.txt";

        public override event PointAddedDelegate PointAdded;

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

        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message.ToUpper());
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
       
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                { 
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        float.TryParse(line, out float point);
                        statistics.AddPointsToStatistics(point);
                    }
                }
            }
            else
            {
                throw new Exception($"The File: {fileName} - not exist");
            }

            return statistics;

            }
    }
}


