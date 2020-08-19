using System;
using Xunit;
using StringCalculator;

namespace StringCalculator.UnitTests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void WithSingleStringArgumentsReturnsThatDigit()
        {
          //Arrange
          var result = Program.StringCalc("3");

          Assert.Equal(result, "3");

        }
        [Fact]
        public void WithMultipleDigitStringInputReturnsSum()
        {
          var result = Program.StringCalc("4,5,6,4,3");
          Assert.Equal(result, "22");
        }
    }
}
