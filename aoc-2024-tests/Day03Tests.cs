using aoc_2024;
using FluentAssertions;

namespace aoc_2024_tests;

[TestFixture]
public class Day03Tests
{
    [Test]
    public void Can_Read_File_Contents()
    {
        // Arrange
        var day03 = new Day03();

        // Act
        var result = day03.ReadInputFile("Day03_Part1_Sample1.txt");

        // Assert
        result.Length.Should().BeGreaterThan(0);
    }
    
    [Test]
    public void Can_Extract_And_Multiply_Four_Numbers()
    {
        // Arrange 
        var day03 = new Day03();
        var mulData = day03.ReadInputFile("Day03.txt");
        
        // Act
        var result = day03.ExtractNumbers(mulData[0]);
        
        // Assert
        result.Should().Be(161);
    }
    
    [Test]
    public void Sum_Multiple_Lines()
    {
        // Arrange 
        var day03 = new Day03();
        var mulData = day03.ReadInputFile("Day03.txt");
        
        // Act
        var result = day03.SumAllLines(mulData);
        
        // Assert
        result.Should().Be(161);
    }
}