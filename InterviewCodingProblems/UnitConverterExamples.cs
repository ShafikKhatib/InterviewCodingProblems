namespace InterviewCodingProblems;

public class UnitConverterExamples
{
    public void Run()
    {
        decimal kilograms = MassConverter.Convert(
            5,
            MassUnit.Pound,
            MassUnit.Kilogram);

        decimal fahrenheit = TemperatureConverter.Convert(
            100,
            TemperatureUnit.Celsius,
            TemperatureUnit.Fahrenheit);

        decimal kilometers = LengthConverter.Convert(
            1,
            LengthUnit.Mile,
            LengthUnit.Kilometer);

        decimal milliliters = VolumeConverter.Convert(
            2,
            VolumeUnit.Liter,
            VolumeUnit.Milliliter);

        decimal paise = IndianMoneyConverter.Convert(
            250.50m,
            IndianMoneyUnit.Rupee,
            IndianMoneyUnit.Paise);
    }
}