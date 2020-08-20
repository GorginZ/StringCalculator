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
      var result = Program.Add("3");

      Assert.Equal(result, "3");

    }
    [Fact]
    public void WithMultipleDigitStringInputReturnsSum()
    {
      var result = Program.Add("4,5,6,4,3");
      Assert.Equal(result, "22");
    }
    [Fact]
    public void NewLineOrCommarSeperatorShouldReturnSum()
    {
      var result = Program.Add("1,2\n3");
      Assert.Equal(result, "6");
    }
    [Fact]
    public void SupportsOtherDelimiters()

    {
      var result = Program.Add("//;\n1;2");
      Assert.Equal(result, "3");
    }
    [Fact]
    public void CallingWithaNegativeShouldThrowException()

    {
      Assert.Throws(typeof(Exception), () => Program.Add("-1,2,-3"));
    }
    [Fact]
    public void IgnoresLargeNumbers()

    {
      var result = Program.Add("1000,1001,2");
      Assert.Equal("2",result);
    }

  }
}
