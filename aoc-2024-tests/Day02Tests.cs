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
    public void Next_Number_Is_Higher()
    {
        // Arrange
        var day02 = new Day02();
        var reports = day02.ReadInputFile("Day02_Part1_Sample.txt");

        // Act
        day02.LoadReports(reports);
        
        // Assert
        day02.GetReports().Length.Should().BeGreaterThan(0);

    }
}