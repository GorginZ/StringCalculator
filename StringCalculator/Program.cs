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
       
            string[] newNums = Regex.Split(numbers, @"[,\n]");
            
            var res = 0;
            foreach (string element in newNums)
            {
                int workingNum = Int32.Parse(element);
                res += workingNum;
            }
            
            return res.ToString();
        }
    }
}
