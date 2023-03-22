namespace Note.Helpers;

public class Calculator
{
    public int Add(string numbersInput)
    {
        var parsedNumbers = numbersInput
            .Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries)
            .Select(m => int.Parse(m));
        return parsedNumbers.Sum();

    }
}