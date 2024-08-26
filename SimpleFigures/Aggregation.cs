namespace SimpleFigures;

class Aggregation : IFigure
{
    private List<IFigure> shapes = [];
    private readonly (double X, double Y) origin = (0, 0);

    /// <summary>
    /// The Add method adds a shape to a collection of figures.
    /// </summary>
    /// <param name="IFigure">The parameter `IFigure` in the `Add` method represents an interface type. This
    /// means that any object that implements the `IFigure` interface can be passed as an argument to this
    /// method. This allows for flexibility and polymorphism in the code, as different types of figures can
    /// be added to</param>
    public void Add(IFigure shape)
    {
        shapes.Add(shape);
    }

    /// <summary>
    /// This function removes a shape object from a collection of shapes.
    /// </summary>
    /// <param name="IFigure">The `IFigure` parameter in the `Remove` method represents an interface that
    /// defines the behavior for a figure or shape. This interface likely contains methods or properties
    /// that are common to different types of figures, allowing them to be treated polymorphically. When a
    /// figure object that implements this interface is passed</param>
    public void Remove(IFigure shape)
    {
        shapes.Remove(shape);
    }

    /// <summary>
    /// The Move function iterates through a collection of shapes and moves each shape by the specified x
    /// and y coordinates.
    /// </summary>
    /// <param name="x">The parameter `x` represents the amount by which the shapes should be moved along
    /// the x-axis.</param>
    /// <param name="y">The parameter `y` in the `Move` method represents the distance by which the shapes
    /// will be moved along the y-axis.</param>
    public void Move(double x, double y)
    {
        foreach (var shape in shapes)
        {
            shape.Move(x, y);
        }
    }

    /// <summary>
    /// The Rotate method applies a rotation transformation to a collection of shapes around a specified
    /// center point.
    /// </summary>
    /// <param name="angle">The `angle` parameter in the `Rotate` method represents the amount by which the
    /// shapes will be rotated. It is a double value that specifies the angle of rotation in
    /// degrees.</param>
    /// <param name="center">The `center` parameter is a nullable tuple of two `double` values, representing
    /// the X and Y coordinates of the center point around which the shapes will be rotated. If a `center`
    /// value is provided, the shapes will be rotated around that center point. If no `center` value
    /// is</param>
    public void Rotate(double angle, (double X, double Y)? center = null)
    {
        foreach (var shape in shapes)
        {
            shape.Rotate(angle, center ?? origin);
        }
    }
}