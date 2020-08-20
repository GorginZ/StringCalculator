using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to step 4 calculator enter some numers eg: 2,5,2,1,3");
      var numbers = Console.ReadLine();
      Console.WriteLine(Add(numbers));
    }
    public static string Add(string numbers)
    {

      var exceptionMessage = new StringBuilder($"Negatives not allowed: ");
      Regex negs = new Regex(@"-[0-9]+");
      MatchCollection matches = negs.Matches(numbers);
      foreach (Match match in matches)
      {
        exceptionMessage.Append($"{match},");
      }
      if (matches.Count > 0)
      {
        throw new Exception(exceptionMessage.ToString().Trim(','));
      }

      string[] newNums = Regex.Split(numbers, @"[^0-9]+");
      var sum = 0;
      int workingNum;
      bool resBool;
      //added tryparse and something to handle if any empty chars slip through the regex (which they are)
      foreach (string element in newNums)
      {
        resBool = int.TryParse(element, out workingNum);

        if (resBool == true && workingNum < 1000)
        {
          sum += workingNum;
        }
      }

      return sum.ToString();
    }
  }
}
