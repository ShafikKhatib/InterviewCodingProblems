namespace InterviewCodingProblems;

public static class IndianCurrencyToWords
{
    private static readonly string[] Ones =
    [
        "Zero",
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven",
        "Eight",
        "Nine",
        "Ten",
        "Eleven",
        "Twelve",
        "Thirteen",
        "Fourteen",
        "Fifteen",
        "Sixteen",
        "Seventeen",
        "Eighteen",
        "Nineteen"
    ];

    private static readonly string[] Tens =
    [
        "",
        "",
        "Twenty",
        "Thirty",
        "Forty",
        "Fifty",
        "Sixty",
        "Seventy",
        "Eighty",
        "Ninety"
    ];

    private static readonly (long Value, string Name)[] IndianScales =
    [
        (100_00_00_00_00_00_00_000, "Shankh"),
        (1_00_00_00_00_00_00_000, "Padma"),
        (1_00_00_00_00_00_00_000 / 10, "Neel"),
        (1_00_00_00_00_00_00_000 / 100, "Kharab"),
        (1_00_00_00_00_00_00_000 / 1000, "Arab"),
        (1_00_00_000, "Crore"),
        (1_00_000, "Lakh"),
        (1_000, "Thousand")
    ];

    public static string Convert(decimal amount)
    {
        decimal roundedAmount = decimal.Round(
            amount,
            2,
            MidpointRounding.AwayFromZero);

        decimal amountInPaise = roundedAmount * 100;

        if (amountInPaise != decimal.Truncate(amountInPaise))
        {
            throw new ArgumentException(
                "Amount cannot contain more than two decimal places.",
                nameof(amount));
        }

        long totalPaise;

        try
        {
            totalPaise = checked((long)amountInPaise);
        }
        catch (OverflowException exception)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "The amount is too large to convert.",
                exception);
        }

        bool isNegative = totalPaise < 0;
        ulong absolutePaise = GetAbsoluteValue(totalPaise);

        long rupees = (long)(absolutePaise / 100);
        long paise = (long)(absolutePaise % 100);

        string result = $"Rupees {NumberToWords(rupees)}";

        if (paise > 0)
        {
            result += $" and {NumberToWords(paise)} Paise";
        }

        result += " Only";

        return isNegative ? $"Minus {result}" : result;
    }

    private static ulong GetAbsoluteValue(long value)
    {
        return value < 0
            ? (ulong)(-(value + 1)) + 1
            : (ulong)value;
    }

    private static string NumberToWords(long number)
    {
        if (number == 0)
        {
            return "Zero";
        }

        List<string> parts = [];

        foreach ((long value, string name) in IndianScales)
        {
            if (number < value)
            {
                continue;
            }

            long quotient = number / value;
            number %= value;

            parts.Add(NumberToWords(quotient));
            parts.Add(name);
        }

        if (number >= 100)
        {
            parts.Add(Ones[number / 100]);
            parts.Add("Hundred");
            number %= 100;
        }

        if (number > 0)
        {
            parts.Add(ConvertBelowOneHundred(number));
        }

        return string.Join(' ', parts);
    }

    private static string ConvertBelowOneHundred(long number)
    {
        if (number < 20)
        {
            return Ones[number];
        }

        return number % 10 == 0
            ? Tens[number / 10]
            : $"{Tens[number / 10]} {Ones[number % 10]}";
    }
}