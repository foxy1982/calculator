using System;

namespace calculator
{
    internal class Calculator
    {
        public decimal Calculate(string text)
        {
            var parts = text.Split(' ');
            var firstNumber = Convert.ToInt32(parts[0]);
            var operation = parts[1];
            var secondNumber = Convert.ToInt32(parts[2]);

            var result = 0m;
            switch (operation)
            {
                case "x":
                    result = new Multiplier().Multiply(firstNumber, secondNumber);
                    break;

                case "+":
                    result = new Adder().Add(firstNumber, secondNumber);
                    break;

                case "-":
                    result = new Subtractor().Subtract(firstNumber, secondNumber);
                    break;

                case "/":
                    result = new Divider().Divide(firstNumber, secondNumber);
                    break;
            }

            return result;
        }
    }
}