namespace MineField;

public class Program
{
    public static void Main()
    {
        // The Minefiled is represented as a 2D array of integers.
        // `0` represents an empty cell and `1` represents a cell with a mine.
        Field mineField = new Field(new int[,] {
            {0, 0, 1, 1, 0},
            {1, 1, 0, 1, 0},
            {0, 1, 1, 0, 1},
            {1, 0, 1, 0, 1},
            {0, 1, 0, 1, 1}
        });

        // Print the minefield
        Console.WriteLine("Minefield:");
        Console.WriteLine(mineField.ToString());

        SnifferPup pup = new SnifferPup(mineField);

        pup.Sniff();

        pup.Move(FieldDirections.Up);
    }
}