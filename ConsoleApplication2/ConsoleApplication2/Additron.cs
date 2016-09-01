namespace ConsoleApplication2
{
    public interface IAdditron
    {
        decimal Add(string[] args);
    }

    public class Additron : IAdditron
    {
        public decimal Add(string[] args)
        {
            return decimal.Parse(args[0]) + decimal.Parse(args[2]);
        }
    }
}