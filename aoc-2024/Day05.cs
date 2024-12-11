

using Microsoft.VisualBasic.FileIO;

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


    public List<PageOrderingRule> CreateRules(string[] listOfRules)
    {
        var pageOrderingRules = listOfRules.Select(line =>
            {
                var parts = line.Split("|");
                return new PageOrderingRule
                {
                    FirstPageNumber = int.Parse(parts[0]),
                    SecondPageNumber = int.Parse(parts[1]),
                };
            }

        ).ToList();
        return pageOrderingRules;
    }

    public List<Page> CreatePages(List<PageOrderingRule> rules)
    {
        var pages = new List<Page>();
        foreach (var rule in rules)
        {
            pages.Add(new Page { Number = rule.FirstPageNumber, MustBeBefore = new List<int>(), MustBeAfter = new List<int>() });
        }
        return new List<Page>();
    }
}

public class PageOrderingRule
{
    public int FirstPageNumber { get; set; }
    public int SecondPageNumber { get; set; }
}

public class Page
{
    public int Number { get; set; }
    public required List<int> MustBeBefore { get; set; }
    public required List<int> MustBeAfter { get; set; }
}