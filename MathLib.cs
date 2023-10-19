public static class MathLib
{
    public static LinearFunction x { get; private set; } = new();

    public static Function cos(Function f)
    {
        var result = new AggregateFunction();
        result.Function = f;
        result.Aggregation = new CosAggregation();
        return result;
    }
}