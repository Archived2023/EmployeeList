namespace EmployeeList.MSTest
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            //Arrange
            const uint juniorSalaryLevel = 10000;
            const string name = "Kalle";

            var emp = new Employee(name, juniorSalaryLevel);
            var expected = SalaryLevel.Junior;

            //Act
            var actual = emp.SalaryLevel;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        //[TestMethod]
        [DataTestMethod]
        [DataRow(2u)]
        [DataRow(10000u)]
        [DataRow(24999u)]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior2(uint salary)
        {
            //Arrange
            const string name = "Kalle";

            var emp = new Employee(name, salary);
            var expected = SalaryLevel.Junior;

            //Act
            var actual = emp.SalaryLevel;

            //Assert
            Assert.AreEqual(expected, actual);
         }


        }
}