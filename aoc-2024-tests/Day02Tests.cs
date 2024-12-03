using aoc_2024;
using FluentAssertions;

namespace aoc_2024_tests;

[TestFixture]
public class Day02Tests
{
    [Test]
    public void Can_Read_File_Contents()
    {
        // Arrange
        var day02 = new Day02();

        // Act
        var result = day02.ReadInputFile("Day02_Part1_Sample.txt");

        // Assert
        result.Length.Should().BeGreaterThan(0);
    }
    
    [Test]
    public void Loading_Reports_Has_Length()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");

        // Act
        day02.LoadReports(reports);
        
        // Assert
        day02.GetReports().Length.Should().BeGreaterThan(0);
    }

    [Test]
    public void Report_String_Split_Into_Int_Array()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);
        
        // Act
        var result = day02.SplitIntoIntArray(day02.GetReports()[0]);
        
        // Assert
        result.Length.Should().Be(5);
    }
    
    [Test]
    public void Next_Number_Is_Higher_Returns_False()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);

        // Act
        var result = day02.IsNextNumberHigher(0);

        // Assert
        result.Should().BeFalse();
    }
    
    [Test]
    public void Pair_Is_In_Safe_Range()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);
        var intArray = day02.SplitIntoIntArray(reports[0]);
        
        //Act
        var result = day02.IsPairInSafeRange(intArray[0], intArray[1]);
        
        // Assert
        result.Should().BeTrue();
    }
    
    [Test]
    public void Check_Each_Number_In_Report()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);
        var intArray = day02.SplitIntoIntArray(reports[3]);
        
        //Act
        var result = day02.CheckEachNumberInReportIsSafe(intArray);
        
        // Assert
        result.Should().BeTrue();
    }

    [Test]
    public void Report_Has_Numbers_Within_Three_Of_Each_Other()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);
        
        //Act
        var result = day02.ReportIsSafe(day02.GetReports()[0]);
        
        // Assert
        result.Should().BeTrue();
    }
    
    [Test]
    public void Number_Of_Safe_Reports()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02.txt");
        day02.LoadReports(reports);
        
        //Act
        var result = day02.NumberOfSafeReports(reports);
        
        // Assert
        result.Should().Be(2);
    }
    
    [Test]
    public void Are_All_Increasing()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);
        var intArray = day02.SplitIntoIntArray(reports[1]);
        
        //Act
        var result = day02.ReportIsAccending(intArray);
        
        // Assert
        result.Should().BeTrue();
    }
    
    [Test]
    public void Are_All_Decreasing()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");
        day02.LoadReports(reports);
        var intArray = day02.SplitIntoIntArray(reports[0]);
        
        //Act
        var result = day02.ReportIsDecending(intArray);
        
        // Assert
        result.Should().BeTrue();
    }
}