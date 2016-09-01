namespace ConsoleApplication2
{
    public interface ISubtractor
    {
        decimal Subtract(string[] args);
    }

    public class Subtractor : ISubtractor
    {
        public decimal Subtract(string[] args)
        {
            return decimal.Parse(args[0]) - decimal.Parse(args[2]);
        }
    }
}