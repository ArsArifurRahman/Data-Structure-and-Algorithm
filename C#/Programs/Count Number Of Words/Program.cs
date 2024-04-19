int CountWords(string value)
{
    if (string.IsNullOrEmpty(value))
    {
        return 0;
    }

    int words = 1;

    for (int i = 0; i < value.Length; i++)
    {
        if (value[i] == ' ')
        {
            words++;
        }
    }

    return words;
}

Console.WriteLine(CountWords("Hello World!"));