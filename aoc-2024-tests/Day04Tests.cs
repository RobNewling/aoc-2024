using System.Reflection;
using aoc_2024;
using FluentAssertions;

namespace aoc_2024_tests;

[TestFixture]
public class Day04Tests
{
    [Test]
    public void Can_Read_File_Contents()
    {
        // Arrange
        var day04 = new Day04();

        // Act
        var result = day04.ReadInputFile("Day04_Part1_Sample.txt");

        // Assert
        result.Length.Should().BeGreaterThan(0);
    }
}