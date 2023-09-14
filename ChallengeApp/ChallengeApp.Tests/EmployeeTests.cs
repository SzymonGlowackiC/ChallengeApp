using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckEmployeeMaxGrade()
        {
            //arrange
            var employee = new Employee("Adam", "Kamilzelich");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Max);
        }
        [Test]
        public void CheckEmployeeMinGrade()
        {
            //arrange
            var employee = new Employee("Adam", "Kamilzelich");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void CheckEmployeeAverageGrade()
        {
            //arrange
            var employee = new Employee("Adam", "Kamilzelich");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}