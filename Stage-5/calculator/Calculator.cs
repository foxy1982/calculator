using System;

namespace calculator
{
    internal class Calculator
    {
        private IQueryParser _queryParser;
        private IMultiplier _multiplier;
        private IAdder _adder;
        private ISubtractor _subtractor;
        private IDivider _divider;

        public Calculator(IQueryParser queryParser, IMultiplier multipler, IAdder adder, ISubtractor subtractor, IDivider divider)
        {
            _queryParser = queryParser;
            _multiplier = multipler;
            _adder = adder;
            _subtractor = subtractor;
            _divider = divider;
        }

        public decimal Calculate(string text)
        {
            var query = _queryParser.Parse(text);

            var result = 0m;
            switch (query.Operation)
            {
                case "x":
                    result = _multiplier.Multiply(query.FirstNumber, query.SecondNumber);
                    break;

                case "+":
                    result = _adder.Add(query.FirstNumber, query.SecondNumber);
                    break;

                case "-":
                    result = _subtractor.Subtract(query.FirstNumber, query.SecondNumber);
                    break;

                case "/":
                    result = _divider.Divide(query.FirstNumber, query.SecondNumber);
                    break;
            }

            return result;
        }
    }
}