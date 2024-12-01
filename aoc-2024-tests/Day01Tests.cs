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

    [Test]
    public void Sorted_List_Returns_Minimum_Value()
    {
        // Arrange
        var day01 = new Day01();
        var inputData = day01.ReadInputFile("Day01.txt");
        day01.LoadIntoLists(inputData);
        
        // Act
        day01.SortLists();
        
        // Assert
        var min = day01.GetListOne().Min();
        var firstElement = day01.GetListOne().First();
        firstElement.Should().Be(min);
    }

    [Test]
    public void Returns_Distance_Between_Two_Elements()
    {
        // Arrange
        var day01 = new Day01();
        var inputData = day01.ReadInputFile("Day01.txt");
        day01.LoadIntoLists(inputData);
        day01.SortLists();
        
        // Act
        var result = day01.DistanceBetweenElements(0);

        // Assert
        result.Should().Be(14);
    }

    [Test]
    public void Sums_Total_Difference_Of_All_Elements()
    {
        // Arrange
        var day01 = new Day01();
        var inputData = day01.ReadInputFile("Day01.txt");
        day01.LoadIntoLists(inputData);
        day01.SortLists();
        
        // Act
        var result = day01.SumAllDifferences();
        
        // Assert
        result.Should().BeGreaterThan(14);
    }
}