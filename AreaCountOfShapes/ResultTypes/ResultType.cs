namespace AreaCountOfFigures.ResultTypes;

public abstract record ResultType
{
    public sealed record RightAngled : ResultType;

    public sealed record ObtuseAngled : ResultType;

    public sealed record AcuteAngled: ResultType;

    public sealed record IncorrectShape : ResultType;


}
