namespace ChallengeApp.Tests
{
    internal class AddCharPoints
    {
        [Test]
        public void WhenAddLetterAAndB_ShouldReturnCorrectStats()
        {
            //ARRANGE
            var employee = new Employee();

            //Act
            employee.AddPoints('A');
            employee.AddPoints('B');
            var statistics = employee.GetStatistics();

            //ASSERT
            Assert.AreEqual(2, statistics.Count);
            Assert.AreEqual(90, statistics.Avg);
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(80, statistics.Min);
            Assert.AreEqual('A', statistics.AvgLetter);
        }

        [Test]
        public void WhenAddLetterC_ShouldReturnStatsWithCResults()
        {
            //ARRANGE
            var employee = new Employee();

            //Act
            employee.AddPoints('C');
            var statistics = employee.GetStatistics();

            //ASSERT
            Assert.AreEqual(1, statistics.Count);
            Assert.AreEqual(60, statistics.Avg);
            Assert.AreEqual(60, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
            Assert.AreEqual('C', statistics.AvgLetter);
        }
    }
}
