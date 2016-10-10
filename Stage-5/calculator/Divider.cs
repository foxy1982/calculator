namespace calculator
{
    internal class Divider : IDivider
    {
        public decimal Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}