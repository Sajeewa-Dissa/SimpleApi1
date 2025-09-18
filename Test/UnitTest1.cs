using Microsoft.AspNetCore.Mvc;
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
            string returnString = controller?.Get(2)?.Content?.ToString() ?? "";
            Assert.Equal("Get returned 2", returnString);
        }

        [Fact]
        public void Test1()
        {
            // Extract the value
            var actualList = controller.Get().Value?.ToList() ?? new List<string>(); // Q. does this ever return null?

            List<string> expectedValues = new List<string> { "value1", "value2", "value3" };

            // Assert
            Assert.Equal(expectedValues.Count, actualList.Count);
            Assert.True(expectedValues.All(expected => actualList.Contains(expected)),
                "The IEnumerable does not contain all expected values.");
        }

        [Fact]
        public void Test2()
        {
            string input = "HelloWorld";
            string expected = $"Called values Post method passing in string {input}";

            // Act
            ActionResult<string> result = controller.PostValue(input);

            // Assert
            var okResult = Assert.IsType<ActionResult<string>>(result);
            var value = Assert.IsType<string>(okResult.Value);
            Assert.Equal(expected, value);

            Assert.Equal("aa", "AA", true);
            Assert.Equal(12, 12);
        }
    }
}