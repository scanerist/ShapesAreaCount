using AreaCountOfFigures.ValidateShapes;

namespace AreaCountOfFigures;

public interface ITriangle : IShape
{
    double FirstSide { get; }
    double SecondSide { get; }
    double ThirdSide { get; }
    
}