using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(StringCalc("2,4,2,1,5,6"));
        }
        public static string StringCalc(string numbers)
        {
            var newNums = numbers.Split(",");
            var res = 0;
            int count = 0;

            foreach (string element in newNums)
            {
                count++;
                int workingNum = Int32.Parse(element);
                res += workingNum;
              // Console.WriteLine(res);
               
            }
            
            return res.ToString();
        }
    }
}
