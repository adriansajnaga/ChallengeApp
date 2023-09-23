namespace ChallengeApp.Tests
{
    public class AddEmployee
    {

        [Test]
        public void WhenAddEmployeeAdam_ShouldReturnNameAdam()
        {
            //ARRANGE
            var employee = new Employee("Adam", "Kamizelich");


            //Act
            employee.AddPoints(5);
            employee.AddPoints(-6);
            var name = employee.Name;

            //ASSERT
            Assert.AreEqual("Adam", name);
        }
    }
}