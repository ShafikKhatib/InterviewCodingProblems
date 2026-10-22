namespace InterviewCodingProblems;

public static class SortWordsByLength
{
    public static string Sort(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);

        List<string> words = [];
        List<char> punctuationMarks = [];

        foreach (string token in sentence.Split(
                     (char[]?)null,
                     StringSplitOptions.RemoveEmptyEntries))
        {
            string word = new(token.Where(char.IsLetterOrDigit).ToArray());

            punctuationMarks.AddRange(
                token.Where(character => !char.IsLetterOrDigit(character)));

            if (word.Length > 0)
            {
                words.Add(word);
            }
        }

        string sortedWords = string.Join(
            ' ',
            words
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase));

        return sortedWords + new string(punctuationMarks.ToArray());
    }

    //without using built-in sort function
    public static string SortWithoutBuiltInSort(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);
        List<string> words = [];
        List<char> punctuationMarks = [];
        foreach (string token in sentence.Split(
                     (char[]?)null,
                     StringSplitOptions.RemoveEmptyEntries))
        {
            string word = new(token.Where(char.IsLetterOrDigit).ToArray());
            punctuationMarks.AddRange(
                token.Where(character => !char.IsLetterOrDigit(character)));
            if (word.Length > 0)
            {
                words.Add(word);
            }
        }
        // Implementing a simple bubble sort for demonstration
        for (int i = 0; i < words.Count - 1; i++)
        {
            for (int j = 0; j < words.Count - i - 1; j++)
            {
                if (words[j].Length > words[j + 1].Length ||
                    (words[j].Length == words[j + 1].Length &&
                     string.Compare(words[j], words[j + 1], StringComparison.OrdinalIgnoreCase) > 0))
                {
                    // Swap
                    string temp = words[j];
                    words[j] = words[j + 1];
                    words[j + 1] = temp;
                }
            }
        }
        string sortedWords = string.Join(' ', words);
        return sortedWords + new string(punctuationMarks.ToArray());
    }

    //using LINQ to sort words by length and then alphabetically
    public static string SortWithLinq(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);
        List<string> words = [];
        List<char> punctuationMarks = [];
        foreach (string token in sentence.Split(
                     (char[]?)null,
                     StringSplitOptions.RemoveEmptyEntries))
        {
            string word = new(token.Where(char.IsLetterOrDigit).ToArray());
            punctuationMarks.AddRange(
                token.Where(character => !char.IsLetterOrDigit(character)));
            if (word.Length > 0)
            {
                words.Add(word);
            }
        }
        string sortedWords = string.Join(
            ' ',
            words
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase));
        return sortedWords + new string(punctuationMarks.ToArray());
    }



}