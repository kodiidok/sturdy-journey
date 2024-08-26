namespace SimpleFigures;

class Point(double x, double y) : IFigure
{
    private double X { get; set; } = x;
    private double Y { get; set; } = y;

    public (double X, double Y) GetCoordinates() => (X, Y);

    public override string ToString() => $"({X}, {Y})";

    /// <summary>
    /// The Move function increments the X and Y coordinates by the specified values.
    /// </summary>
    /// <param name="x">
    /// The parameter `x` represents the amount by which the object should move along the x-axis.
    /// </param>
    /// <param name="y">
    /// The parameter `y` in the `Move` method represents the amount by which the object's Y coordinate will be moved.
    /// </param>
    public void Move(double x, double y)
    {
        X += x;
        Y += y;
    }

    /// <summary>
    /// The Rotate function takes an angle in degrees as input and is used to rotate an object.
    /// The rotation is performed around a given center or the origin, in anti-clockwise direction.
    /// The rotation matrix is used to calculate the new coordinates of the object after the rotation.
    /// </summary>
    /// <param name="deg">The "deg" parameter in the Rotate method represents the amount by which the
    /// object should be rotated. This value is typically specified in degrees, indicating the angle of
    /// rotation to be applied to the object.</param>
    public void Rotate(double deg, (double X, double Y)? center = null)
    {
        // Math.Cos(90) is caluclated as 6.123233995736766E-17 instead of 0
        // Math.Sin(90) is calculated as 1

        double rad = deg * (Math.PI / 180);

        double[,] rotMatrix = {
            { Math.Cos(rad), -Math.Sin(rad) },
            { Math.Sin(rad), Math.Cos(rad) }
        };

        // Determine the center of rotation
        double centerX = center.HasValue ? center.Value.X : 0;
        double centerY = center.HasValue ? center.Value.Y : 0;

        // Translate the point to the origin (center of rotation)
        double translatedX = X - centerX;
        double translatedY = Y - centerY;

        // Apply the rotation
        double rotatedX = rotMatrix[0, 0] * translatedX + rotMatrix[0, 1] * translatedY;
        double rotatedY = rotMatrix[1, 0] * translatedX + rotMatrix[1, 1] * translatedY;

        // Translate the point back to its original position
        X = rotatedX + centerX;
        Y = rotatedY + centerY;
    }

}