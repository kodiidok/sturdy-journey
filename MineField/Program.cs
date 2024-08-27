namespace MineField;

public class Program
{
    public static void Main()
    {
        // The Minefiled is represented as a 2D array of integers.
        // `0` represents an empty cell and `1` represents a cell with a mine.
        // Field mineField = new Field(new int[,] {
        //     {0, 0, 1, 1, 0},
        //     {1, 1, 0, 1, 0},
        //     {0, 1, 1, 0, 1},
        //     {1, 0, 1, 0, 1},
        //     {0, 1, 0, 1, 1}
        // });


        Field mineField = new Field(new int[,] {
            {0, 0, 1},
            {1, 1, 0},
            {0, 0, 1}
        });

        // Print the minefield
        Console.WriteLine("Minefield:");
        Console.WriteLine(mineField.ToString());

        SnifferPup pup = new SnifferPup(mineField);
        HashSet<GraphNode> sniffed = pup.Sniff(mineField.GetGrid()[0, 0]);

        if (sniffed != null && sniffed.Count > 0)
        {
            Console.WriteLine("Safe path found:");
            foreach (var node in sniffed)
            {
                Console.WriteLine($"Node ID: {node.Id}, Value: {node.Value}");
            }
        }
        else
        {
            Console.WriteLine("No safe path found.");
        }
    }
}