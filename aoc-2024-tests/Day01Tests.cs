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

    [Test]
    public void Can_Load_Into_Two_Lists()
    {
        // Arrange
        var day01 = new Day01();
        var inputData = day01.ReadInputFile("Day01.txt");
        
        // Act
        day01.LoadIntoLists(inputData);
        
        // Assert
        day01.GetListOneLength().Should().BeGreaterThan(0);
        day01.GetListTwoLength().Should().BeGreaterThan(0);
    }
}