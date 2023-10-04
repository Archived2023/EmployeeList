using EmployeeList.Helpers;
using EmployeeList.UI;
using Moq;

namespace EmployeeList.XUnitTest
{
    public class UtilTests
    {
        [Fact]
        public void AskForString_ShouldReturnString()
        {
            const string expected = "some input";
            var mockUI = new MockUI();
            mockUI.SetInput = expected;

            var actual = Util.AskForString("", mockUI);

            Assert.Equal(expected, actual); 
        }  
        
        [Fact]
        public void AskForString_ShouldReturnString_WithMOQ()
        {
            const string expected = "some input";
            var mockUI = new Mock<IUI>();
            mockUI.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("", mockUI.Object);

            Assert.Equal(expected, actual); 
        }
    }
}