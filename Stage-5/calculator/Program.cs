using System;

namespace calculator
{
    internal class Program
    {
        private static Calculator _calculator;

        private static void Main(string[] args)
        {
            Bootstrap();
            Console.WriteLine("Enter a query (e.g. 5 x 8):");
            var myString = Console.ReadLine();
            Console.WriteLine(_calculator.Calculate(myString));
            Console.ReadLine();
        }

        private static void Bootstrap()
        {
            _calculator = new Calculator(new QueryParser(), new Multiplier(), new Adder(), new Subtractor(), new Divider());
        }
    }
}