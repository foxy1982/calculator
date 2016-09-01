namespace ConsoleApplication2
{
    public interface IStringToArrayYay
    {
        string[] TurnIntoStringArray(string args);
    }

    public class StringToArrayYay : IStringToArrayYay
    {
        public string[] TurnIntoStringArray(string args)
        {
            var stringArray = args.Split(' ');
            return stringArray;
        }
    }
}