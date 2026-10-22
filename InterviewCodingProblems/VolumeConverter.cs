namespace InterviewCodingProblems;

public enum VolumeUnit
{
    Milliliter,
    Liter,
    CubicMeter,
    Teaspoon,
    Tablespoon,
    Cup,
    Gallon
}

public static class VolumeConverter
{
    public static decimal Convert(decimal value, VolumeUnit from, VolumeUnit to)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Volume cannot be negative.");
        }

        decimal valueInLiters = from switch
        {
            VolumeUnit.Milliliter => value / 1000m,
            VolumeUnit.Liter => value,
            VolumeUnit.CubicMeter => value * 1000m,
            VolumeUnit.Teaspoon => value * 0.00492892159m,
            VolumeUnit.Tablespoon => value * 0.0147867648m,
            VolumeUnit.Cup => value * 0.2365882365m,
            VolumeUnit.Gallon => value * 3.785411784m,
            _ => throw new ArgumentOutOfRangeException(nameof(from))
        };

        return to switch
        {
            VolumeUnit.Milliliter => valueInLiters * 1000m,
            VolumeUnit.Liter => valueInLiters,
            VolumeUnit.CubicMeter => valueInLiters / 1000m,
            VolumeUnit.Teaspoon => valueInLiters / 0.00492892159m,
            VolumeUnit.Tablespoon => valueInLiters / 0.0147867648m,
            VolumeUnit.Cup => valueInLiters / 0.2365882365m,
            VolumeUnit.Gallon => valueInLiters / 3.785411784m,
            _ => throw new ArgumentOutOfRangeException(nameof(to))
        };
    }
}