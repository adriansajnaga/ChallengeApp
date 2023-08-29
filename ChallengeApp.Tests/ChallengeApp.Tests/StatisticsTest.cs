namespace ChallengeApp.Tests

{
    internal class StatisticsTest
    {
        [Test]
        public void WhenAddPoints_ShouldFindMinValue()
        {
            var employee1 = new Employee("Adrian", "Sajnaga");
            employee1.AddPoints(5);
            employee1.AddPoints(-6);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual(-6, statistics.Min);
        }

        [Test]
        public void WhenAddPoints_ShouldFindMaxValue()
        {
            var employee1 = new Employee("Adrian", "Sajnaga");
            employee1.AddPoints(5);
            employee1.AddPoints(-6);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void WhenAddPoints_ShouldCalculateAverageValue()
        {
            var employee1 = new Employee("Adrian", "Sajnaga");
            employee1.AddPoints(5);
            employee1.AddPoints(-6);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual(-0.5, statistics.Avg);
        }

        [Test]
        public void WhenAddMaxFloatAndMinFloat_ShouldEqualZero()
        {
            var employee1 = new Employee("Adrian", "Sajnaga");
            employee1.AddPoints(float.MinValue);
            employee1.AddPoints(float.MaxValue);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual(0, statistics.Max);
            
        }
    }
}
