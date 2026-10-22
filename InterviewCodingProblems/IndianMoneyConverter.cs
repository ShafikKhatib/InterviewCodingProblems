namespace InterviewCodingProblems;

public enum IndianMoneyUnit
{
    Rupee,
    Paise
}

public static class IndianMoneyConverter
{
    public static decimal Convert(
        decimal value,
        IndianMoneyUnit from,
        IndianMoneyUnit to)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(value),
                "Indian currency value cannot be negative.");
        }

        decimal valueInPaise = from switch
        {
            IndianMoneyUnit.Rupee => value * 100m,
            IndianMoneyUnit.Paise => value,
            _ => throw new ArgumentOutOfRangeException(nameof(from))
        };

        return to switch
        {
            IndianMoneyUnit.Rupee => valueInPaise / 100m,
            IndianMoneyUnit.Paise => valueInPaise,
            _ => throw new ArgumentOutOfRangeException(nameof(to))
        };
    }
}