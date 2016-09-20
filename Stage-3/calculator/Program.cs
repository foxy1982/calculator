using System;

namespace calculator
{
    internal class Program
    {
        private static Calculator _calculator = new Calculator();

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a query (e.g. 5 x 8):");
            var myString = Console.ReadLine();
            Console.WriteLine(_calculator.Calculate(myString));
            Console.ReadLine();
        }
    }
}