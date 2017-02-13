using System;

namespace KataStringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator calculator = new StringCalculator();

            Console.WriteLine("No numbers:");
            Console.WriteLine("Result: {0}", calculator.Add(""));
            Console.WriteLine("Two numbers:");
            Console.WriteLine("Result: {0}", calculator.Add("1,3"));
            Console.WriteLine("Three numbers:");
            Console.WriteLine("Result: {0}", calculator.Add("1,3,4"));

            Console.ReadKey();
        }
    }
}
