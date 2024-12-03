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

    public bool IsNextNumberHigher(int index)
    {
        var report = SplitIntoIntArray(_reports[0]);
        return report[index] < report[index + 1];
    }

    public int[] SplitIntoIntArray(string report)
    {
        return report.Split(' ').Select(int.Parse).ToArray();
    }

    public bool ReportIsSafe(string report)
    {
        var intArray = SplitIntoIntArray(report);
        return ProvideSecondChance(intArray);
    }

    private bool ProvideSecondChance(int[] intArray)
    {
        if (CheckEachNumberInReportIsSafe(intArray) && (ReportIsAccending(intArray) ^ ReportIsDecending(intArray)))
        {
            return true;
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            var secondChanceArray = intArray.Where((num, index) => index != i).ToArray();
            if (CheckEachNumberInReportIsSafe(secondChanceArray) && (ReportIsAccending(secondChanceArray) ^ ReportIsDecending(secondChanceArray)))
            {
                return true;
            }
        }

        return false;
    }

    public bool CheckEachNumberInReportIsSafe(int[] report)
    {
        for (int i = 0; i < report.Length - 1; i++)
        {
            if (IsPairInSafeRange(report[i], report[i + 1]) == false)
            {
                return false;
            };
        }
        return true;
    }

    public bool ReportIsAccending(int[] report)
    {
        for (int i = 0; i < report.Length - 1; i++)
        {
            if (report[i] >= report[i + 1])
            {
                return false;
            };
        }
        return true;
    }
    
    public bool ReportIsDecending(int[] report)
    {
        for (int i = 0; i < report.Length - 1; i++)
        {
            if (report[i] <= report[i + 1])
            {
                return false;
            };
        }
        return true;
    }
    

    public bool IsPairInSafeRange(int first, int second)
    {
        return Math.Abs(first - second) <= 3;
    }

    public int NumberOfSafeReports(string[] reports)
    {
        List<string> safeReports = new List<string>();
        foreach (var report in reports)
        {
            if (ReportIsSafe(report))
            {
                safeReports.Add(report);
            }
        }
        return reports.Count(n => ReportIsSafe(n));
    }
}