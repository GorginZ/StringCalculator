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
      //step 6 calls for NO NEGATIVES. So we check for negatives first and throw
      //exception with the list of negative numbers appended as requested.
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
      //should I refactor the regex to be a positive match?
      string[] newNums = Regex.Split(numbers, @"[^0-9]+");
      var sum = 0;
      int workingNum;
      bool resBool;
    //resBool because empty characters slipping through regex
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
