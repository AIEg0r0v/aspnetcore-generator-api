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
    }
}