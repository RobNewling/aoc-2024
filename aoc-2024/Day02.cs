namespace aoc_2024;

public class Day02
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";
    private string[] _reports;
    
    public string[] ReadInputFile(string fileName)
    {
        return File.ReadAllLines(InputFolderPath + "/" + fileName);
    }

    public void LoadReports(string[] reports)
    {
        _reports = reports;
    }

    public string[] GetReports()
    {
        return _reports;
    }
}