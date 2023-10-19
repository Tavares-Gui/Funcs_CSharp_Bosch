public class MultComposition : IComposition
{
    public double Calcule(List<Function> fs, double x)
    {
        double mult = 1;
        foreach (Function f in fs)
            mult *= f[x];
        return mult;
    }

    public Function Derive(List<Function> fs)
        => throw new NotImplementedException();
}