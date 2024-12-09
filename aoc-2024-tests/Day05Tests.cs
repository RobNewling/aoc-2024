using System.Reflection;
using aoc_2024;
using FluentAssertions;

namespace aoc_2024_tests;

[TestFixture]
public class Day05Tests
{
    [Test]
    public void Can_Read_File_Contents()
    {
        // Arrange
        var day05 = new Day05();

        // Act
        var result = day05.ReadInputFile("Day05_Sample.txt");

        // Assert
        result.Length.Should().BeGreaterThan(0);
    }
    
    [Test]
    public void File_Contents_Inserted_In_Lists()
    {
        // Arrange
        var day05 = new Day05();
        var fileContents = day05.ReadInputFile("Day05_Sample.txt");

        // Act
        var (pageOrderingRules, updatePages) = day05.SplitFileInTwo(fileContents);

        // Assert
        pageOrderingRules.Length.Should().BeGreaterThan(0);
        updatePages.Length.Should().BeGreaterThan(0);
    }
}

