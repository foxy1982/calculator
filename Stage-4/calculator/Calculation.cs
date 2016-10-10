namespace calculator
{
    internal class Calculation
    {
        public Calculation(string operation, int firstNumber, int secondNumber)
        {
            Operation = operation;
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public string Operation { get; }

        public int FirstNumber { get; }

        public int SecondNumber { get; }
    }
}