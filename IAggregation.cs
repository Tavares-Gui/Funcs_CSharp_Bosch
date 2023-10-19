public interface IAggregation
{
    double Calcule(Function f, double x);
    Function Derive(Function f);
}