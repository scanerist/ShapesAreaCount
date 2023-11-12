namespace AreaCountOfFigures;

public class Triangle : ITriangle
{
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    public double CountArea()
    {
        double area = Math.Sqrt((FirstSide + SecondSide + ThirdSide) / 2 *
                                ((FirstSide + SecondSide + ThirdSide) / 2 - FirstSide) *
                                ((FirstSide + SecondSide + ThirdSide) / 2 - SecondSide) *
                                ((FirstSide + SecondSide + ThirdSide) / 2 - ThirdSide));
        if (area == 0)
        {
            throw new ArgumentException("incorrect shape!");
        }

        return area;
    }

    public double FirstSide { get; private set; }
    public double SecondSide { get; private set; }
    public double ThirdSide { get; private set; }
}