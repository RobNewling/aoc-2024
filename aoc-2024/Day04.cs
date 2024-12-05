

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
    private List<Space> _grid = new ();

    public Grid(int width, int height)
    {
        CreateBlankSpaces(width, height);
    }
    
    public Grid(string[] input)
    {
        CreateSpaces(input);
    }

    private void CreateSpaces(string[] input)
    {
        for (int x = 0; x < input[0].Length; x++)
        {
            for (int y = 0; y < input.Count(); y++)
            {
                _grid.Add(new Space(x, y, input[x][y]));
            }
        }
    }

    private void CreateBlankSpaces(int width, int height)
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                _grid.Add(new Space(x, y, '.'));
            }
        }
    }

    public char GetValueAt(int x, int y)
    {
        return _grid.Find(s => s.Position() == (x, y)).Value();
    }

    public Grid Find(string sequence)
    {
        var chars = sequence.ToCharArray();
        foreach (var space in _grid)
        {
            if (space.Value() == sequence[0])
            {
                return new Grid(1,1);
            }
        }
        return new Grid(0,0);
    }

    private void DirectionalSearch(Space startingSpace)
    {
        
    }

    public int Size()
    {
        return _grid.Count;
    }
}

public class Space
{
    private (int, int) _position;
    private char _value;

    public Space(int x, int y, char value)
    {
        _position = (x, y);
        _value = value;
    }

    public (int, int) Position()
    {
        return _position;
    }
    
    public char Value()
    {
        return _value;
    }

    public void SetValue(char value)
    {
        _value = value;
    }
}