namespace ChallengeApp
{
    public class Employee                                           //KLASA
    {
        private List<int> listOfPoints = new List<int>();
         public Employee(string name, string surname, int age)      //KONSTRUKTOR
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddPoints(int points)                           //METODA KLASY
        {
            this.listOfPoints.Add(points);
        }

        public int SumOfPoints
        {
            get
            {
                return this.listOfPoints.Sum();
            }
        }                 
        
    }
}
