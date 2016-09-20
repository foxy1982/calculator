using System;

namespace calculator
{
    internal class Calculator
    {
        public decimal Calculate(string text)
        {
            var query = new QueryParser().Parse(text);

            var result = 0m;
            switch (query.Operation)
            {
                case "x":
                    result = new Multiplier().Multiply(query.FirstNumber, query.SecondNumber);
                    break;

                case "+":
                    result = new Adder().Add(query.FirstNumber, query.SecondNumber);
                    break;

                case "-":
                    result = new Subtractor().Subtract(query.FirstNumber, query.SecondNumber);
                    break;

                case "/":
                    result = new Divider().Divide(query.FirstNumber, query.SecondNumber);
                    break;
            }

            return result;
        }
    }
}