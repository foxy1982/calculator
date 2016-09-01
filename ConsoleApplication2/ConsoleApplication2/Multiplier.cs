namespace ConsoleApplication2
{
    public interface IMultiplier
    {
        decimal Mulitply(string[] args);
    }

    public class Multiplier : IMultiplier
    {
        public decimal Mulitply(string[] args)
        {
            return decimal.Parse(args[0]) * decimal.Parse(args[2]);
        }
    }
}