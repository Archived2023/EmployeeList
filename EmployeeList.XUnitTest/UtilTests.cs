using EmployeeList.Helpers;
using EmployeeList.UI;

namespace EmployeeList.XUnitTest
{
    public class UtilTests
    {
        [Fact]
        public void Test1()
        {
            const string expected = "some input";
            var mockUI = new MockUI();
            mockUI.SetInput = expected;

            var actual = Util.AskForString("", mockUI);

            Assert.Equal(expected, actual); 
        }
    }
}