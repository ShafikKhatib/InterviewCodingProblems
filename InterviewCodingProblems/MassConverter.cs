namespace InterviewCodingProblems;

public enum MassUnit
{
    Milligram,
    Gram,
    Kilogram,
    Ounce,
    Pound
}

public static class MassConverter
{
    public static decimal Convert(decimal value, MassUnit from, MassUnit to)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Mass cannot be negative.");
        }

        decimal valueInGrams = from switch
        {
            MassUnit.Milligram => value / 1000m,
            MassUnit.Gram => value,
            MassUnit.Kilogram => value * 1000m,
            MassUnit.Ounce => value * 28.349523125m,
            MassUnit.Pound => value * 453.59237m,
            _ => throw new ArgumentOutOfRangeException(nameof(from))
        };

        return to switch
        {
            MassUnit.Milligram => valueInGrams * 1000m,
            MassUnit.Gram => valueInGrams,
            MassUnit.Kilogram => valueInGrams / 1000m,
            MassUnit.Ounce => valueInGrams / 28.349523125m,
            MassUnit.Pound => valueInGrams / 453.59237m,
            _ => throw new ArgumentOutOfRangeException(nameof(to))
        };
    }
}