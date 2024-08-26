namespace SimpleFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and display circles
            Circle c1 = new Circle(0, 0, 5);
            Circle c2 = new Circle(1, 1, 3);

            Console.WriteLine("Initial Circles:");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());

            // Move the first circle and display the result
            c1.Move(2, 1);
            Console.WriteLine("\nCircle c1 after moving to (2, 1):");
            Console.WriteLine(c1.ToString());

            // Create and display point
            Point p1 = new Point(8, -2);
            Console.WriteLine("\nInitial Point:");
            Console.WriteLine(p1.ToString());

            // Rotate the point and display the result
            p1.Rotate(45, new(4, -4));
            Console.WriteLine("\nPoint p1 after rotating 45 degrees around (4, -4):");
            Console.WriteLine(p1.ToString());

            // Create and display line
            Line l1 = new Line(-7, -5, 9, 7);
            Console.WriteLine("\nInitial Line:");
            Console.WriteLine(l1.ToString());

            // Move and rotate the line, then display the result
            l1.Move(1, -6);
            Console.WriteLine("\nLine l1 after moving to (1, -6):");
            Console.WriteLine(l1.ToString());

            l1.Rotate(-45, new(0, 0));
            Console.WriteLine("\nLine l1 after rotating -45 degrees around (0, 0):");
            Console.WriteLine(l1.ToString());

            // Create and display aggregation
            Aggregation aggregation = new Aggregation();
            aggregation.Add(c1);
            aggregation.Add(c2);
            aggregation.Add(l1);
            aggregation.Add(p1);

            Console.WriteLine("\nAggregation before transformations:");
            Console.WriteLine(aggregation.ToString());

            // Move and rotate the aggregation, then display the result
            aggregation.Move(2, 1);
            Console.WriteLine("\nAggregation after moving by (2, 1):");
            Console.WriteLine(aggregation.ToString());

            aggregation.Rotate(45, new(0, 0));
            Console.WriteLine("\nAggregation after rotating 45 degrees around (0, 0):");
            Console.WriteLine(aggregation.ToString());
        }
    }
}
