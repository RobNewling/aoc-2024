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

    [Test]
    public void Grid_Returns_Value_At_Space()
    {
        // Arrange
        var grid = new Grid(2,2);
        
        // Act
        var result = grid.GetValueAt(0, 0);

        // Assert
        result.Should().Be('.');
    }
    
    [Test]
    public void Grid_Returns_Loaded_Value_At_Space()
    {
        // Arrange
        var day04 = new Day04();
        var input = day04.ReadInputFile("Day04_Part1_Sample.txt");
        var grid = new Grid(input);
        
        // Act
        var result = grid.GetValueAt(0, 0);

        // Assert
        result.Should().Be('M');
    }
    
    [Test]
    public void Chomper_Finds_XM()
    {
        // Arrange
        var day04 = new Day04();
        var input = day04.ReadInputFile("Day04_Part1_Sample.txt");
        var grid = new Grid(input);
        var sequence = "XM";
        
        // Act
        var result = grid.Find(sequence);

        // Assert
        result.Should().BeGreaterThan(0);
    }
    
    [Test]
    public void Chomper_Finds_XMAS()
    {
        // Arrange
        var day04 = new Day04();
        var input = day04.ReadInputFile("Day04_Part1_SmallSample.txt");
        var grid = new Grid(input);
        var sequence = "XMAS";
        
        // Act
        var result = grid.Find(sequence);

        // Assert
        result.Should().Be(3);
    }
}

