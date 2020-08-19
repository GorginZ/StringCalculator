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
            // var newString = Regex.Replace(numbers, @"[^0-9]",""); 
            
            // @"[,;\n;]"
             string[] newNums = Regex.Split(numbers, @"[^0-9]+");
             var newString = newNums.ToString();
             newString = Regex.Replace(newString, @"[^0-9]", "");
             string[] workingNums = newString.Split();
             
            var res = 0;
            foreach (string element in workingNums)
            {
                int workingNum = Int32.Parse(element);
                res += workingNum;
            }
            
            return res.ToString();
        }
    }
}
