namespace SimpleFigures;

class Circle(double x, double y, double radius) : IFigure
{

    private Point _center = new(x, y);
    private double _radius = radius;

    /// <summary>
    /// The GetCircle function returns the standard equation of a circle based on its center coordinates and
    /// radius.
    /// </summary>
    /// <returns>
    /// The `GetCircle` method returns a string representing the standard equation of a circle in the form
    /// `(x - h)^2 + (y - k)^2 = r^2`, where (h, k) is the center of the circle and r is the radius. The
    /// values for h, k, and r are obtained from the `_center` and `_radius` properties of the class.
    /// </returns>
    public override string ToString()
    {
        // standard equation of the circle in the form 
        // (𝑥−ℎ)^2 +(𝑦−𝑘)^2 = 𝑟^2 where (ℎ,𝑘) is the center of the circle and r is the radius.

        string f = $"(x - {_center.GetCoordinates().X})^2 + (y - {_center.GetCoordinates().Y})^2 = {_radius * _radius}";
        return f;
    }

    /// <summary>
    /// The Move function moves the center point by the specified x and y coordinates.
    /// </summary>
    /// <param name="x">The parameter `x` represents the amount of movement along the horizontal
    /// axis.</param>
    /// <param name="y">The parameter `y` represents the amount by which the object will move along the
    /// y-axis.</param>
    public void Move(double x, double y)
    {
        _center.Move(x, y);
    }

    /// <summary>
    /// The Rotate function rotates an object around a specified center point by a given angle.
    /// </summary>
    /// <param name="angle">The `angle` parameter is a double value representing the amount of rotation in
    /// degrees.</param>
    /// <param name="center">The `center` parameter is a tuple containing two `double` values, `X` and `Y`,
    /// representing the coordinates of the center point for rotation. This parameter is optional and can be
    /// set to `null`.</param>
    public void Rotate(double angle, (double X, double Y)? center = null)
    {
        _center.Rotate(angle, center);
    }
}