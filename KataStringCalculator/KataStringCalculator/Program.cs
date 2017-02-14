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
            Console.WriteLine("Two numbers, \\n delimitator:");
            Console.WriteLine("Result: {0}", calculator.Add("1\n3"));
            Console.WriteLine("Three numbers, ',' and '\\n' delimitators:");
            Console.WriteLine("Result: {0}", calculator.Add("1\n3,4"));
            Console.WriteLine("Invalid format");
            Console.WriteLine("Result: {0}", calculator.Add("11,\n"));

            Console.ReadKey();
        }
    }
}
