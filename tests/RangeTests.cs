using System;
using System.Linq;
using api.Controllers;
using Xunit;

namespace tests
{
    public class RangeTests
    {
        [Fact]
        public void Count_ControlNumberOfResults()
        {
            //Arrange
            var range = new Range { Count = 3 };

            //Act
            var generated = range.Of(() => "");

            //Assert
            Assert.Equal(3, generated.Count());
        }

        [Fact]
        public void Sort_OrderResults()
        {
            //Arrange
            var range = new Range { Count = 3, Sort = true };
            var values = new[] { "a", "c", "b" };
            var counter = 0;
            //Act
            var generated = range.Of(() => values[counter++]);

            //Assert
            Assert.Equal(new[] { "a", "b", "c" }, generated.ToArray());
        }
    }
}