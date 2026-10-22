namespace InterviewCodingProblems;

public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}

public static class TemperatureConverter
{
    public static decimal Convert(
        decimal value,
        TemperatureUnit from,
        TemperatureUnit to)
    {
        decimal valueInCelsius = from switch
        {
            TemperatureUnit.Celsius => value,
            TemperatureUnit.Fahrenheit => (value - 32m) * 5m / 9m,
            TemperatureUnit.Kelvin => value - 273.15m,
            _ => throw new ArgumentOutOfRangeException(nameof(from))
        };

        if (valueInCelsius < -273.15m)
        {
            throw new ArgumentOutOfRangeException(
                nameof(value),
                "Temperature cannot be below absolute zero.");
        }

        return to switch
        {
            TemperatureUnit.Celsius => valueInCelsius,
            TemperatureUnit.Fahrenheit => valueInCelsius * 9m / 5m + 32m,
            TemperatureUnit.Kelvin => valueInCelsius + 273.15m,
            _ => throw new ArgumentOutOfRangeException(nameof(to))
        };
    }
}