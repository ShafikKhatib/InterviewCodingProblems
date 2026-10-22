namespace InterviewCodingProblems;

public enum LengthUnit
{
    Millimeter,
    Centimeter,
    Meter,
    Kilometer,
    Inch,
    Foot,
    Yard,
    Mile
}

public static class LengthConverter
{
    public static decimal Convert(decimal value, LengthUnit from, LengthUnit to)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Length cannot be negative.");
        }

        decimal valueInMeters = from switch
        {
            LengthUnit.Millimeter => value / 1000m,
            LengthUnit.Centimeter => value / 100m,
            LengthUnit.Meter => value,
            LengthUnit.Kilometer => value * 1000m,
            LengthUnit.Inch => value * 0.0254m,
            LengthUnit.Foot => value * 0.3048m,
            LengthUnit.Yard => value * 0.9144m,
            LengthUnit.Mile => value * 1609.344m,
            _ => throw new ArgumentOutOfRangeException(nameof(from))
        };

        return to switch
        {
            LengthUnit.Millimeter => valueInMeters * 1000m,
            LengthUnit.Centimeter => valueInMeters * 100m,
            LengthUnit.Meter => valueInMeters,
            LengthUnit.Kilometer => valueInMeters / 1000m,
            LengthUnit.Inch => valueInMeters / 0.0254m,
            LengthUnit.Foot => valueInMeters / 0.3048m,
            LengthUnit.Yard => valueInMeters / 0.9144m,
            LengthUnit.Mile => valueInMeters / 1609.344m,
            _ => throw new ArgumentOutOfRangeException(nameof(to))
        };
    }
}