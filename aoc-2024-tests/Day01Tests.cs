using aoc_2024;
using FluentAssertions;

namespace aoc_2024_tests;

[TestFixture]
public class Day01Tests
{
    [Test]
    public void Can_Read_File_Contents()
    {
        // Arrange
        var day01 = new Day01();

        // Act
        var result = day01.ReadInputFile("Day01.txt");

        // Assert
        result.Length.Should().BeGreaterThan(0);
    }
}