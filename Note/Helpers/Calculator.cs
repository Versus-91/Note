namespace Note.Helpers;

public class Calculator
{
    public int Add(string numbersInput)
    {
        var parsedNumbers = numbersInput.Split(",");
        if (!parsedNumbers.Any())
        {
            return 0;
        }

        if (parsedNumbers.Length == 1)
        {
            if (parsedNumbers[0].Length == 0)
            {
                return 0;
            }

            return int.Parse(parsedNumbers[0]);
        }
        return int.Parse(parsedNumbers[0])+int.Parse(parsedNumbers[1]);
    }
}