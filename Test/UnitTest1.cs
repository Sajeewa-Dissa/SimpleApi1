using SimpleApi1.Controllers;
using Xunit;

namespace SimpleApi1.Test
{
    public class UnitTest1
    {
        private ValuesController controller = new ValuesController(); //bad practice - added this way only for convenience.

        [Fact]
        public void GetReturnsSomething()
        {
            string returnString = controller.Get(2).Content.ToString() ?? "";
            Assert.Equal("Get returned 2", returnString);
        }

        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("aa", "AA", true);
            Assert.Equal(12, 12);
        }
    }
}