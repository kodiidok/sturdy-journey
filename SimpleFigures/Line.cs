namespace SimpleFigures;

class Line(double x1, double y1, double x2, double y2) : IFigure
{
    private Point _point1 = new(x1, y1);
    private Point _point2 = new(x2, y2);

    /// <summary>
    /// The Move function moves two points by the specified x and y coordinates.
    /// </summary>
    /// <param name="x">The parameter `x` represents the amount by which the points `_point1` and `_point2`
    /// will be moved horizontally.</param>
    /// <param name="y">The `y` parameter in the `Move` method represents the amount by which the points
    /// will be moved along the vertical axis.</param>
    public void Move(double x, double y)
    {
        _point1.Move(x, y);
        _point2.Move(x, y);
    }

    /// <summary>
    /// The Rotate function rotates two points around an optional center point by a specified degree.
    /// </summary>
    /// <param name="deg">The `deg` parameter is a double value representing the angle in degrees by which
    /// the points `_point1` and `_point2` will be rotated.</param>
    /// <param name="center">The `center` parameter is a nullable tuple of two doubles, representing the X
    /// and Y coordinates of the center point for rotation. If a center point is provided, the `Rotate`
    /// method will rotate `_point1` and `_point2` around that center point by the specified angle
    /// `deg`.</param>
    public void Rotate(double deg, (double X, double Y)? center = null)
    {
        _point1.Rotate(deg, center);
        _point2.Rotate(deg, center);
    }
}