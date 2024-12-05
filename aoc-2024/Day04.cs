

namespace aoc_2024;

// Envisioning a snake that is going through a plane
// it's looking for yummy food to eat.
// It can only eat a certain sequence
// So if it finds the first symbol, it then looks in all 
// possible directions to check if the it can find the 
// next symbol. The only rules are
// 1. each symbol must be one step away from the previous one and
// 2. it can't go passed the grid

public class Day04
{
    private const string InputFolderPath = "/Users/robnewling/Projects/aoc-2024/aoc-2024/Inputs";

    public string[] ReadInputFile(string fileName)
    {
        return File.ReadAllLines(InputFolderPath + "/" + fileName);
    }

}

public class Grid
{
    private char[,] _grid;

    public Grid(int width, int height)
    {
        _grid = new char[width, height];
        CreateBlankSpaces();
    }
    
    public Grid(string[] input)
    {
        _grid = new char[input[0].Length, input.Count()];
        CreateSpaces(input);
    }

    private void CreateSpaces(string[] input)
    {
        for (int x = 0; x < _grid.GetLength(0); x++)
        {
            for (int y = 0; y < _grid.GetLength(1); y++)
            {
                _grid[x, y] = input[x][y];
            }
        }
    }

    private void CreateBlankSpaces()
    {
        for (int x = 0; x < _grid.GetLength(0); x++)
        {
            for (int y = 0; y < _grid.GetLength(1); y++)
            {
                _grid[x, y] = '.';
            }
        }
    }

    public char GetValueAt(int x, int y)
    {
        return _grid[x, y];
    }
}