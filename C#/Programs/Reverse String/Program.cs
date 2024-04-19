string ReverseString(string value)
{
    string reverse = "";

    for (int i = value.Length - 1; i >= 0; i--)
    {
        reverse += value[i];
    }

    return reverse;
}

Console.WriteLine(ReverseString("C# is Awesome!"));