using System;

namespace StringCalculator
{
        
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to step 4 calculator enter some numers eg: 2,5,2,1,3");
            var numbers = Console.ReadLine();
            Console.WriteLine(StringCalc(numbers));
        }
        public static string StringCalc(string numbers)
        {
            var newNums = numbers.Split(",");
            var res = 0;
            int count = 0;
            //refactor to not use loop?
            foreach (string element in newNums)
            {
                count++;
                int workingNum = Int32.Parse(element);
                res += workingNum;
            }
            
            return res.ToString();
        }
    }
}
