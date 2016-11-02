namespace calculator
{
    public interface IQueryParser
    {
        Calculation Parse(string text);
    }
}