public class CosAggregation : IAggregation
{
    public double Calcule(Function f, double x)
        => Math.Cos(f[x]);

    public Function Derive(Function f)
    {
        throw new NotImplementedException();
    }
}