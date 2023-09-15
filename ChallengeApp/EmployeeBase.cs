namespace ChallengeApp
{
	public abstract class EmployeeBase : iEmployee
	{
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddPoints(float points);

        public virtual void AddPoints(double points)
        {
            float result = (float)points;
            this.AddPoints(result);
        }

        public virtual void AddPoints(char points)
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

        public virtual void AddPoints(long points)
        {
            float result = Convert.ToSingle(points);
            this.AddPoints(result);
        }

        public virtual void AddPoints(int points)
        {
            float result = points;
            AddPoints(result);
        }

        public abstract void AddPoints(string points);

        public abstract Statistics GetStatistics();
    }
}
