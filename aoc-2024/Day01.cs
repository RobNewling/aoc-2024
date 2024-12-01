namespace aoc_2024;

public class Day01
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";
    private List<int> _listOne  = new ();
    private List<int> _listTwo  = new ();
    
    public string[] ReadInputFile(string fileName)
    {
        return File.ReadAllLines(InputFolderPath + "/" + fileName);
    }

    public void LoadIntoLists(string[] inputData)
    {
        foreach (string line in inputData)
        {
            AddSplitLineToLists(SplitLine(line));
        }
    }

    private string[] SplitLine(string line)
    {
        return line.Split("   ");
    }

    private void AddSplitLineToLists(string[] splitLine)
    {
        _listOne.Add(int.Parse(splitLine[0]));
        _listTwo.Add(int.Parse(splitLine[1]));
    }

    public int GetListOneLength()
    {
        return _listOne.Count;
    }

    public int GetListTwoLength()
    {
        return _listTwo.Count;
    }

    public void SortLists()
    {
        _listOne.Sort();
        _listTwo.Sort();
    }

    public List<int> GetListOne()
    {
        return _listOne;
    }
    
    public List<int> GetListTwo()
    {
        return _listTwo;
    }

    public int DistanceBetweenElements(int index)
    {
        return Math.Abs(_listTwo[index] - _listOne[index]);
    }

    public int SumAllDifferences()
    {
        int sum = 0;
        for (int i = 0; i < _listOne.Count; i++)
        {
            sum += DistanceBetweenElements(i);
        }
        return sum;
    }

    public int FindNumberOfOccurrencesInRightList(int leftElement)
    {
        return _listTwo.FindAll(x => x == leftElement).Count;
    }

    public int CalculateSimilarityScore()
    {
        var similarityScore = 0;
        for (int i = 0; i < _listOne.Count; i++)
        {
            var leftElement = _listOne[i];
            similarityScore += leftElement * FindNumberOfOccurrencesInRightList(leftElement);
        }
        return similarityScore;
    }
}