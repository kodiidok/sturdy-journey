namespace MineField;

class SnifferPup
{
    private readonly Field _field;

    public SnifferPup(Field field)
    {
        _field = field;
    }

    public HashSet<GraphNode>? Sniff(GraphNode root)
    {
        Console.WriteLine("Sniffing for mines...");

        if (root.Value == 1) return null; // Cannot start from a Land mine

        // Create a queue to store paths based on safety
        var queue = new Queue<GraphNode>();
        queue.Enqueue(root);

        HashSet<GraphNode> visited = new HashSet<GraphNode>();
        HashSet<GraphNode> safe = new HashSet<GraphNode>();

        while (queue.Count > 0)
        {
            foreach (var node in queue)
            {
                Console.Write(node.Id + " ");
            }
            Console.WriteLine();

            var currentNode = queue.Dequeue();

            if (!visited.Contains(currentNode))
            {
                visited.Add(currentNode);
                if (currentNode.Value == 0) safe.Add(currentNode);

                var directions = new List<GraphNode?>
                {
                    currentNode.UpLeft,
                    currentNode.Up,
                    currentNode.UpRight,
                    currentNode.Right,
                    currentNode.DownRight,
                    currentNode.Down,
                    currentNode.DownLeft,
                    currentNode.Left
                };

                foreach (var direction in directions)
                {
                    if (direction != null && direction.Value == 0 && !visited.Contains(direction) && direction.Id != null && currentNode.Id != null)
                    {
                        int directionRow = int.Parse(direction.Id.Split(",")[0]);
                        int currentNodeRow = int.Parse(currentNode.Id.Split(",")[0]);

                        if (directionRow >= currentNodeRow)
                        {
                            queue.Enqueue(direction);
                        }
                    }
                }
            }
        }

        return safe;
    }

}