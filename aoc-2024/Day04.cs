

namespace aoc_2024;

// Envisioning a snake that is going through a plane
// it's looking for yummy food to eat.
// It can only eat a certain sequence
// So if it finds the first symbol, it then looks in all 
// possible directions to check if the it can find the 
// next symbol. The only rules are
// 1. each symbol must be one step away from the previous one 
// in straight line from the point of origin, and
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
        for (int y = 0; y < input.Count(); y++)
        {
            for (int x = 0; x < input[y].Length; x++)
            {
                _grid.Add(new Space(x, y, input[y][x]));
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

    public Space GetSpaceAt(int x, int y)
    {
        return _grid.Find(s => s.Position() == (x, y));
    }

    public int Find(string sequence)
    {
        var score = 0;
        var restOfChars = RestOfChars(sequence);
        foreach (var space in _grid)
        {
            if (space.Value() == sequence[0])
            {
                score += SearchDirection(space, restOfChars, GetSpaceEastOf);
            }
        }

        return score;
    }

    private static char[] RestOfChars(string sequence)
    {
        var restOfChars = sequence.Substring(1,sequence.Length-1).ToCharArray();
        return restOfChars;
    }

    private int DirectionalSearch(Space startingSpace, char[] forValues, int score)
    {
        if (forValues.Length > 0)
        {
            
        }

        return score;
    }

    private int SearchDirection(Space startingSpace, char[] forValues, Func<Space, Space> methodOfSearch)
    {
        var nextSpace = startingSpace;
        var pass = true;
        foreach (var value in forValues)
        {
            if (pass)
            {
                nextSpace = methodOfSearch(nextSpace);
                if (nextSpace is null || !nextSpace.Value().Equals(value))
                {
                    pass = false;
                }
            }
            else
            {
                return 0;
            }
        }

        return 1;
    }

    private Space? GetSpaceEastOf(Space startingSpace)
    {
        var (x, y) = startingSpace.Position();
        var newXPos = x + 1;
        if (newXPos > Size())
        {
            //out of bounds
            return null;
        }
        return GetSpaceAt(newXPos, y);
    }
    
    private Space? GetSpaceSouthEastOf(Space startingSpace)
    {
        var (x, y) = startingSpace.Position();
        var newXPos = x + 1;
        var newYPos = y + 1;
        if (newXPos > Size() || newYPos > Size())
        {
            //out of bounds
            return null;
        }
        return GetSpaceAt(newXPos, newYPos);;
    }
    
    private Space? GetSpaceSouthOf(Space startingSpace)
    {
        var (x, y) = startingSpace.Position();
        var newYPos = y + 1;
        if (newYPos > Size())
        {
            //out of bounds
            return null;
        }
        return GetSpaceAt(x, newYPos);;
    }
    
    private Space? GetSpaceWestOf(Space startingSpace)
    {
        var (x, y) = startingSpace.Position();
        var newXPos = x - 1;
        if (newXPos < 0)
        {
            //out of bounds
            return null;
        }
        return GetSpaceAt(newXPos, y);;
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