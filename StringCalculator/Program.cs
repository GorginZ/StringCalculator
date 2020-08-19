using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StringCalculator
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to step 4 calculator enter some numers eg: 2,5,2,1,3");
      var numbers = Console.ReadLine();
      Console.WriteLine(StringCalc(numbers));
    }
    public static string StringCalc(string numbers)
    {

      string[] newNums = Regex.Split(numbers, @"[^0-9]+");


      var res = 0;
      foreach (string element in newNums)
      {
        int workingNum;
        bool resBool;
        resBool = int.TryParse(element, out workingNum);
        if (resBool == true)
        {
          res += workingNum;
        }
        if (resBool == false)
        {
          continue;
        }

      }

      return res.ToString();
    }
  }
}
