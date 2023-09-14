namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act


            //assert
            Assert.AreNotEqual(number1, number2);
        }

        private Employee GetUser(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
