namespace Note.Helpers;

public class Calculator
{
    public int Add(string numbersInput)
    {
        var delimiters = new char[] { ',', '\n' };
        var parsedNumbers = numbersInput
            .Split(delimiters,StringSplitOptions.RemoveEmptyEntries)
            .Select(m => int.Parse(m));
        return parsedNumbers.Sum();

    }
}