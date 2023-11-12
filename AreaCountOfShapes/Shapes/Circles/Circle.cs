namespace AreaCountOfFigures.Circles;

public class Circle : ICircle
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CountArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double Radius { get; }
}