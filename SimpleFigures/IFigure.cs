interface IFigure
{
    void Rotate(double angle, (double X, double Y)? center = null);
    void Move(double x, double y);
}