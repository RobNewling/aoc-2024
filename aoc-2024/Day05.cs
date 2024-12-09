

namespace aoc_2024;

public class Day05
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";

    private string[] _pageOrderingRiles;
    private string[] _updatePages;
    
    public string[] ReadInputFile(string fileName)
    {
        return File.ReadAllLines(InputFolderPath + "/" + fileName);
    }

    public (string[] pageOrderingRules, string[] updatePages) SplitFileInTwo(string[] fileContents)
    {
        var emptyLineIndex = Array.FindIndex(fileContents, string.IsNullOrWhiteSpace);

        if (emptyLineIndex == -1)
        {
            return ([], []);
        }
        
        _pageOrderingRiles = fileContents.Take(emptyLineIndex).ToArray();
        _updatePages = fileContents.Skip(emptyLineIndex + 1).ToArray();
        
        return (_pageOrderingRiles, _updatePages);
    }
    
    

}

