namespace calculator
{
    internal interface IQueryParser
    {
        Calculation Parse(string text);
    }
}