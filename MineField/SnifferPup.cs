namespace MineField;

class SnifferPup
{
    private readonly Field _field;

    public SnifferPup(Field field)
    {
        _field = field;
    }

    public HashSet<GraphNode> Sniff(GraphNode root)
    {
        Console.WriteLine("Sniffing for mines...");

        // Create a priority queue to store paths based on safety
        var queue = new Queue<GraphNode>();
        queue.Enqueue(root);

        HashSet<GraphNode> visited = new HashSet<GraphNode>();
        HashSet<GraphNode> safe = new HashSet<GraphNode>();

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            if (!visited.Contains(currentNode))
            {
                visited.Add(currentNode);
                if (currentNode.Value == 0) safe.Add(currentNode);

                if (currentNode.UpLeft != null) queue.Enqueue(currentNode.UpLeft);
                if (currentNode.Up != null) queue.Enqueue(currentNode.Up);
                if (currentNode.UpRight != null) queue.Enqueue(currentNode.UpRight);
                if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                if (currentNode.DownRight != null) queue.Enqueue(currentNode.DownRight);
                if (currentNode.Down != null) queue.Enqueue(currentNode.Down);
                if (currentNode.DownLeft != null) queue.Enqueue(currentNode.DownLeft);
                if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
            }
        }

        return safe;
    }
}