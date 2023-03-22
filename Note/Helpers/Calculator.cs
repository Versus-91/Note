namespace Note.Helpers;

public class Calculator
{
    public int Add(string numbersInput)
    {
        char[] delimiters = new char[] { ',', '\n' };
        if (numbersInput.StartsWith("//"))
        {
            var splittedByNewLine = numbersInput.Split(new[] { '\n' }, 2);
            var delimitter = splittedByNewLine[0].Replace("//",string.Empty).Single();
            delimiters = delimiters.Append(delimitter).ToArray();
            numbersInput = splittedByNewLine[1];
        }
        var parsedNumbers = numbersInput
            .Split(delimiters,StringSplitOptions.RemoveEmptyEntries)
            .Select(m => int.Parse(m));
        return parsedNumbers.Sum();

    }
}