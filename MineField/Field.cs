namespace MineField;

class Field
{
    private readonly int[,] _grid;
    // private readonly Random _random;


    public Field(int m, int n)
    {
        _grid = new int[m, n];
    }

    public Field(int[,] grid)
    {
        _grid = grid;
    }

    public int[,] GetGrid() => _grid;

    public override string ToString()
    {
        // Initialize a StringBuilder for efficient string concatenation
        var sb = new System.Text.StringBuilder();

        // Iterate through rows
        for (int i = 0; i < _grid.GetLength(0); i++)
        {
            // Iterate through columns in the current row
            for (int j = 0; j < _grid.GetLength(1); j++)
            {
                sb.Append(_grid[i, j] + " ");
            }
            // Add a new line after each row
            sb.AppendLine();
        }

        return sb.ToString();
    }
}