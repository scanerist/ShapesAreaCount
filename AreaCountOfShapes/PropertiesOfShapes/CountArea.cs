namespace AreaCountOfFigures.PropertiesOfShapes;

public class CountArea: ICount
{
    public double Count(IShape shape)
    {
        return shape.CountArea();
    }
}