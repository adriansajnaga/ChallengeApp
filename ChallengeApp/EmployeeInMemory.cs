//namespace ChallengeApp
//{
//    public class EmployeeInMemory : EmployeeBase
//    {
//        private List<float> listOfPoints = new List<float>();

//        public override event PointAddedDelegate PointAdded;

//        public EmployeeInMemory(string name, string surname)
//        :base(name, surname)
//        {
//        }

//        public override void AddPoints(float points)
//        {
//            if (points >= 0 && points <= 100)
//            {
//                this.listOfPoints.Add(points);

//                if (PointAdded != null)
//                {
//                    PointAdded(this, new EventArgs());
//                }
//            }
//            else
//            {
//                throw new Exception($"Invalid value: {points} - out of range");
//            }
//        }

//        public override void AddPoints(string points)
//        {
//            if (float.TryParse(points, out float result))
//            {
//                this.AddPoints(result);
//            }
//            else if (char.TryParse(points, out char charresult))
//            {
//                this.AddPoints(charresult);
//            }
//            else
//            {
//                throw new Exception($"Invalid value: {points} - not float");
//            }
//        }

//        public override Statistics GetStatistics()
//        {
//            var statistics = new Statistics();

//            foreach (var point in this.listOfPoints)
//            {
//                statistics.AddPointsToStatistics(point);
//            }
//            return statistics;
//        }
//    }
//}

