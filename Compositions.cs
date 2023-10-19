public static class Compositions
{
    private static SumComposition sum = null;
    public static SumComposition Sum
    {
        get
        {
            if (sum is null)
                sum = new();
            return sum;
        }
    }
    private static MultComposition mult = null;
    public static MultComposition Mult
    {
        get
        {
            if (mult is null)
                mult = new();
            return mult;
        }
    }
}