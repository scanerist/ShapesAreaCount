using AreaCountOfFigures.ResultTypes;

namespace AreaCountOfFigures.ValidateShapes;

public class ValidateTriangle : IValidate
{
    private readonly ITriangle _triangle;

    public ValidateTriangle(ITriangle triangle)
    {
        _triangle = triangle;
    }

    public ResultType ValidateAngle()
    {
        
        IList<double> sides = new List<double> { _triangle.FirstSide, _triangle.SecondSide, _triangle.ThirdSide }
            .OrderBy(s => s).ToList();
        if (sides[0] + sides[1] <= sides[2])
        {
            return new ResultType.IncorrectShape();
        }
        if (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) > Math.Pow(sides[2], 2))
        {
            return new ResultType.AcuteAngled();
        }
        if(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) < Math.Pow(sides[2], 2))
        {
            return new ResultType.ObtuseAngled();
        }
        return new ResultType.RightAngled();
            
    }
}