using System;

namespace calculator
{
    internal class Calculator
    {
        public decimal Calculate(string text)
        {
            var parts = text.Split(' ');

            var result = 0m;
            switch (parts[1])
            {
                case "x":
                    result = Convert.ToInt32(parts[0]) * Convert.ToInt32(parts[2]);
                    break;

                case "+":
                    result = Convert.ToInt32(parts[0]) + Convert.ToInt32(parts[2]);
                    break;

                case "-":
                    result = Convert.ToInt32(parts[0]) - Convert.ToInt32(parts[2]);
                    break;

                case "/":
                    result = Convert.ToInt32(parts[0]) / Convert.ToInt32(parts[2]);
                    break;
            }

            return result;
        }
    }
}