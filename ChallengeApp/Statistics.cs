namespace ChallengeApp
{
    public class Statistics
    {
        public int Count { get; private set; }

        public float Min { get; private set; }

        public float Sum { get; private set; }

        public float Max { get; private set; }

        public float Avg
        {
            get
            {
                return this.Sum / this.Count;
            }

        }

        public char AvgLetter
        {
            get
            {
                switch (this.Avg)
                {
                    case var a when a > 80:
                        return 'A';
                    case var a when a > 60:
                        return 'B';
                    case var a when a > 40:
                        return 'C';
                    case var a when a > 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
            this.Count = 0;
            this.Sum = 0;
        }

        public void AddPointsToStatistics(float points)
        {
            this.Max = Math.Max(this.Max, points);
            this.Min = Math.Min(this.Min, points);
            this.Sum += points;
            this.Count++;
        }

    }

}