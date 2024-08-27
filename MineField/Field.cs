namespace MineField;

class Field
{
    private readonly GraphNode[,] _grid;

    /// <summary>
    /// Initializes a new instance of the <see cref="Field"/> class with the specified grid.
    /// </summary>
    /// <param name="grid">
    /// A two-dimensional array of integers representing the initial values for each node in the grid.
    /// </param>
    /// <remarks>
    /// This constructor creates a grid of <see cref="GraphNode"/> objects based on the dimensions and values of the provided
    /// integer array. Each node is linked to its adjacent nodes (Up, Down, Left, Right, UpLeft, UpRight, DownLeft, DownRight),
    /// if such nodes exist. If there is no adjacent node in a particular direction, the corresponding property is set to <c>null</c>.
    /// </remarks>
    public Field(int[,] grid)
    {
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        _grid = new GraphNode[rows, cols];

        // First, initialize all the nodes
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                _grid[i, j] = new GraphNode(grid[i, j], $"{i},{j}");
            }
        }

        // Then, link the nodes to their neighbors
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                GraphNode currentNode = _grid[i, j];

                currentNode.Up = i > 0 ? _grid[i - 1, j] : null;
                currentNode.Down = i < rows - 1 ? _grid[i + 1, j] : null;
                currentNode.Left = j > 0 ? _grid[i, j - 1] : null;
                currentNode.Right = j < cols - 1 ? _grid[i, j + 1] : null;
                currentNode.UpLeft = i > 0 && j > 0 ? _grid[i - 1, j - 1] : null;
                currentNode.UpRight = i > 0 && j < cols - 1 ? _grid[i - 1, j + 1] : null;
                currentNode.DownLeft = i < rows - 1 && j > 0 ? _grid[i + 1, j - 1] : null;
                currentNode.DownRight = i < rows - 1 && j < cols - 1 ? _grid[i + 1, j + 1] : null;
            }
        }
    }

    /// <summary>
    /// Retrieves the 2D array of <see cref="GraphNode"/> objects representing the grid.
    /// </summary>
    /// <returns>A 2D array of <see cref="GraphNode"/> representing the grid.</returns>
    public GraphNode[,] GetGrid() => _grid;

    /// <summary>
    /// Returns a string that represents the current grid.
    /// </summary>
    /// <returns>
    /// A <see cref="string"/> that represents the grid, with each node's value displayed in a matrix format.
    /// </returns>
    /// <remarks>
    /// Each row of the grid is represented as a line in the returned string, with the values of the nodes 
    /// separated by spaces. A newline character is appended after each row.
    /// </remarks>
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
                sb.Append(_grid[i, j].Value + " ");
            }
            // Add a new line after each row
            sb.AppendLine();
        }

        return sb.ToString();
    }

    /// <summary>
    /// The StartOptions function returns a list of GraphNode objects from a grid where the search can be started.
    /// </summary>
    /// <returns>
    /// This method `StartOptions()` returns a list of `GraphNode` objects that meet the conditions
    /// specified in the nested loops. The conditions are:
    /// 1. The `Id` property of the `GraphNode` object split by ',' should have the first part equal to "0".
    /// 2. The `Value` property of the `GraphNode` object should be equal to 0.
    /// </returns>
    public List<GraphNode> StartOptions()
    {
        List<GraphNode> list = new List<GraphNode>();
        for (int i = 0; i < _grid.GetLength(0); i++)
        {
            for (int j = 0; j < _grid.GetLength(1); j++)
            {
                if ((_grid[i, j]?.Id?.Split(',')[0] == "0") && (_grid[i, j].Value == 0)) list.Add(_grid[i, j]);
            }
        }
        return list;
    }

    /// <summary>
    /// The function GetById returns a GraphNode from a 2D grid based on the provided indices i and j.
    /// </summary>
    /// <param name="i">The parameter `i` represents the row index in the grid.</param>
    /// <param name="j">The parameter `j` represents the column index in a two-dimensional grid.</param>
    /// <returns>
    /// The method `GetById` returns the `GraphNode` located at the specified indices `i` and `j` in the
    /// `_grid` array.
    /// </returns>
    public GraphNode GetById(int i, int j)
    {
        return _grid[i, j];
    }

}