using System.Text.RegularExpressions;

namespace aoc_2024;

public class Day03
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";
    
    public string[] ReadInputFile(string fileName)
    {
        return File.ReadAllLines(InputFolderPath + "/" + fileName);
    }

    public int ProcessMultiplyCommand(string mulData)
    {
        var numbers = ExtractNumbers(mulData);
        return numbers.FirstNumber * numbers.SecondNumber;
    }

    private ExtractedNumbers ExtractNumbers(string input)
    {
        Regex numberRegex = new Regex(@"(?:mul\()(\d{1,3}),(\d{1,3})\)");
        MatchCollection matches = numberRegex.Matches(input);
        
        return new ExtractedNumbers(int.Parse(matches[0].Groups[1].Value), int.Parse(matches[0].Groups[2].Value));
    }
}

internal class ExtractedNumbers(int firstNumber, int secondNumber)
{
    public int FirstNumber = firstNumber;
    public int SecondNumber = secondNumber;
}