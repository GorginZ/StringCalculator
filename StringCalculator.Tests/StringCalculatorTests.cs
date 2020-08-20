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
          [Fact]
        public void NewLineOrCommarSeperatorShouldReturnSum()
        {
          var result = Program.StringCalc("1,2\n3");
          Assert.Equal(result, "6");
        }
        [Fact]
           public void SupportsOtherDelimiters()
           
        {
          var result = Program.StringCalc("//;\n1;2");
          Assert.Equal(result, "3");
        }
       [Fact]
           public void CallingWithaNegativeShouldThrowException()
           
        {
          var result = Program.StringCalc("-1,2,-3");
          Assert.Equal(result, "Negatives not allowed: -1, -3");
        }}
}
