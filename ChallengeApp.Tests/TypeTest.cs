namespace ChallengeApp.Tests
{
    internal class TypeTest
    {
        [Test]
        public void WhenCompareTwoValueTypesOfTypeInt_ShouldBeEqual()
        {
            int number1 = 199;
            int number2 = 199;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void WhenCompareTwoValueTypesOfTypeFloat_ShouldBeEqual()
        {
            float number1 = float.Pi;
            float number2 = float.Pi;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void WhenCompareTwoReferenceTypesOfTypeString_ShouldBeEqual()
        {
            string string1 = "Adrian";
            string string2 = "Adrian";

            Assert.AreEqual(string1, string2);
        }
        [Test]
        public void WhenCompareTwoReferenceTypes_ShouldNotBeEqual()
        {
            var employee1 = new Employee("Adrian", "Sajnaga");
            var employee2 = new Employee("Adrian", "Sajnaga");
            float name;
            Assert.AreNotEqual(employee1, employee2);
        }
    }
}
