namespace ChallengeApp.Tests

{
    internal class StatisticsTest
    {
        [Test]
        public void WhenAddPoints_ShouldFindMinValue()
        {
            var employee1 = new Employee("Adrian", "Sajnaga");
            employee1.AddPoints(5);
            employee1.AddPoints(1);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual(1, statistics.Min);
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
            employee1.AddPoints(1);
            var statistics = employee1.GetStatistics();
            Assert.AreEqual(3, statistics.Avg);
        }


    }
}
