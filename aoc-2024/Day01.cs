namespace aoc_2024;

public class Day01
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";
    public string ReadInputFile(string fileName)
    {
        return File.ReadAllText(InputFolderPath + "/" + fileName);
    }
}