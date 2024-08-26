namespace MineField;

class SnifferPup
{
    private readonly Field _field;

    public SnifferPup(Field field)
    {
        _field = field;
    }

    public void Sniff()
    {
        List<(int i, int j)> safePath;
        Console.WriteLine("Sniffing for mines...");

        while(true) {

        }
    }

    public void FindSafePath(int i, int j) {
        
    }

    public void Move(FieldDirections direction)
    {
        Console.WriteLine($"Moving {direction}...");
    }
}