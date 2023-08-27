namespace ChallengeApp.Tests
{
    public class AddEmployeeAndPoints
    {
        [Test]
        public void WhenAddPoints_ShouldPositiveResult()
        {
            //ARRANGE
            var employee = new Employee("Adam", "Kamizelich", 35);


            //Act
            employee.AddPoints(5);
            employee.AddPoints(6);
            var sum = employee.SumOfPoints;

            //ASSERT
            Assert.AreEqual (11, sum);
        }

        [Test]
        public void WhenAddMinusPoints_ShouldNegativeResult()
        {
            //ARRANGE
            var employee = new Employee("Adam", "Kamizelich", 35);


            //Act
            employee.AddPoints(-5);
            employee.AddPoints(-6);
            var sum = employee.SumOfPoints;

            //ASSERT
            Assert.AreEqual(-11, sum);
        }
        [Test]
        public void WhenNoAddPoints_ShouldtResultEquals0()
        {
            //ARRANGE
            var employee = new Employee("Adam", "Kamizelich", 35);


            //Act
            var sum = employee.SumOfPoints;

            //ASSERT
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void WhenAddEmployeeAdam_ShouldReturnNameAdam()
        {
            //ARRANGE
            var employee = new Employee("Adam", "Kamizelich", 35);


            //Act
            employee.AddPoints(5);
            employee.AddPoints(-6);
            var name = employee.Name;

            //ASSERT
            Assert.AreEqual("Adam", name);
        }
    }
}