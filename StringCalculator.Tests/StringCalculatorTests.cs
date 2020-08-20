using System;
using Xunit;
using StringCalculator;

namespace StringCalculator.UnitTests
{
  public class StringCalculatorTests
  {

    [Fact]
    public void Step1SingleInputSingleOutput()
    {
      //Arrange
      var result = Program.Add("");
      //"expected", actual
      Assert.Equal("0", result);

    }
    [Fact]
    public void Step2SingleNumberSingleNumberOutputt()
    {
      //Arrange
      var result = Program.Add("3");
      //"expected", actual
      Assert.Equal("3", result);

    }
    [Fact]
    public void Step3TwoNumbersReturnSumOfTwoNumbers()
    {
      //Arrange
      var result = Program.Add("1,2");
      //"expected", actual
      Assert.Equal("3", result);

    }

    [Fact]
    public void Step4WithMultipleDigitStringInputReturnsSum()
    {
      var result = Program.Add("4,5,6,4,3");
      Assert.Equal("22", result);
    }
    [Fact]
    public void Step5NewLineOrCommarSeperatorShouldReturnSum()
    {
      var result = Program.Add("1,2\n3");
      Assert.Equal("6", result);
    }
    [Fact]
    public void Step6SupportsOtherDelimiters()

    {
      var result = Program.Add("//;\n1;2");
      Assert.Equal("3", result);
    }
    [Fact]
    public void Step7CallingWithaNegativeShouldThrowException()

    {
      Assert.Throws(typeof(Exception), () => Program.Add("-1,2,-3"));
    }
    [Fact]
    public void Step8IgnoresNumbersGreaterThan1000()

    {
      var result = Program.Add("1000,1001,2");
      Assert.Equal("2", result);
    }
    [Fact]
    public void Step9DelimitersCanBeOfAnyLengthWFollowingFormat()

    {
      var result = Program.Add("//[***]\n1***2***3");
      Assert.Equal("6", result);
    }
    [Fact]
    public void Step10MultipleDelimiters()

    {
      var result = Program.Add("//[*][%]\n1*2%3");
      Assert.Equal("6", result);
    }
    [Fact]
    public void Step11HandleMultipleDelimitersWithLengthLongerThanOneChar()

    {
      var result = Program.Add("//[***][#][%]\n1***2#3%4");
      Assert.Equal("10", result);
    }
    [Fact]
    public void Step12HandleDelimitersThatHaveNumbersAsPartOfThem()
    // Handle delimiters that have numbers as part of them, where the number cannot be on the edge of a delimiter.
    {
      var result = Program.Add("//[*1*][%]\n1*1*2%3");
      Assert.Equal("6", result);
    }

  }
}
