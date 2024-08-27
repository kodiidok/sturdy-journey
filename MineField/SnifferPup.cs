namespace MineField;

class SnifferPup
{
    private readonly Field _field;

    public SnifferPup(Field field)
    {
        _field = field;
    }

    /// <summary>
    /// Sniffs through a minefield, starting from the given root node, to identify and return a set of safe nodes that can be traversed.
    /// Sniffer Pup navigates through the minefield, identifying safe nodes while ensuring that Ally, who follows Pup, does not step onto
    /// the same field that Pup currently occupies.
    /// </summary>
    /// <param name="root">The starting node (root) from which the sniffing begins. This node must not be a landmine (Value != 1).</param>
    /// <returns>
    /// A HashSet of GraphNode objects representing the safe trail through the minefield. If the root node is a landmine,
    /// the method returns null, indicating that no safe trail is possible from the starting point.
    /// </returns>
    /// <remarks>
    /// The method uses a breadth-first search (BFS) approach to explore all possible safe paths. 
    /// It ensures that Sniffer Pup and Ally do not occupy the same field simultaneously. Ally always steps onto the field 
    /// that Sniffer Pup just vacated, and the search prioritizes moving forward or staying on the same row to maintain safety.
    /// The method assumes that each GraphNode has the following properties:
    /// - Value: An integer representing whether the node is safe (0) or a landmine (1).
    /// - Id: A string identifier in the format "row,column" which helps determine the node's position in the grid.
    /// - Directional properties (UpLeft, Up, UpRight, Right, DownRight, Down, DownLeft, Left): 
    ///   References to adjacent GraphNodes, which are used to explore the minefield.
    /// </remarks>
    public HashSet<GraphNode>? Sniff(GraphNode root)
    {
        Console.WriteLine("Sniffing for mines...");

        if (root.Value == 1) return null; // Cannot start from a Land mine

        // Create a queue to store paths based on safety
        var queue = new Queue<(GraphNode Pup, GraphNode? Ally)>();
        queue.Enqueue((root, null));

        HashSet<GraphNode> visited = new HashSet<GraphNode>();
        HashSet<GraphNode> safe = new HashSet<GraphNode>();

        while (queue.Count > 0)
        {
            var (currentPup, currentAlly) = queue.Dequeue();

            if (!visited.Contains(currentPup))
            {
                visited.Add(currentPup);
                if (currentPup.Value == 0) safe.Add(currentPup);

                var directions = new List<GraphNode?>
                {
                    currentPup.UpLeft,
                    currentPup.Up,
                    currentPup.UpRight,
                    currentPup.Right,
                    currentPup.DownRight,
                    currentPup.Down,
                    currentPup.DownLeft,
                    currentPup.Left
                };

                foreach (var direction in directions)
                {
                    if (direction != null && direction.Value == 0 && !visited.Contains(direction) && direction.Id != null && currentPup.Id != null)
                    {
                        int directionRow = int.Parse(direction.Id.Split(",")[0]);
                        int currentNodeRow = int.Parse(currentPup.Id.Split(",")[0]);

                        if (directionRow >= currentNodeRow)
                        {
                            // Ensure Ally doesn't step onto the same field as Sniffer Pup
                            if (currentAlly == null || !currentAlly.Equals(direction))
                            {
                                queue.Enqueue((direction, currentPup)); // Ally steps onto the newly found safe spot
                            }
                        }
                    }
                }
            }
        }

        return safe;
    }
}