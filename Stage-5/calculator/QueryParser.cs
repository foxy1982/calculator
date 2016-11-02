namespace calculator
{
    using System;

    internal class QueryParser : IQueryParser
    {
        public Calculation Parse(string text)
        {
            var parts = text.Split(' ');
            var firstNumber = Convert.ToInt32(parts[0]);
            var operation = parts[1];
            var secondNumber = Convert.ToInt32(parts[2]);

            return new Calculation(operation, firstNumber, secondNumber);
        }
    }
}