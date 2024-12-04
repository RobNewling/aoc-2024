using System.Text.RegularExpressions;

namespace aoc_2024;

public class Day03
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";
    
    public string[] ReadInputFile(string fileName)
    {
        return File.ReadAllLines(InputFolderPath + "/" + fileName);
    }

    public int SumAllLines(string[] mulData)
    {
        var sum = 0;
        foreach (string line in mulData)
        {
            sum += ExtractNumbers(line);
        }
        return sum;
    }

    public int ExtractNumbers(string input)
    {
        Regex numberRegex = new Regex(@"(?:mul\()(\d{1,3}),(\d{1,3})\)");
        MatchCollection matches = numberRegex.Matches(input);
        return SumMultiples(matches);
    }

    public int SumMultiples(MatchCollection matches)
    {
        var sum = 0;
        foreach (Match match in matches)
        {
            sum += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
        }
        return sum;
    }
}

internal class ExtractedNumbers(int firstNumber, int secondNumber)
{
    public int FirstNumber = firstNumber;
    public int SecondNumber = secondNumber;
}