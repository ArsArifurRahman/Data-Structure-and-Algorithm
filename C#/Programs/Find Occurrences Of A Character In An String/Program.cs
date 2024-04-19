int CountCharacter(string value, char single)
{
    int count = 0;

    foreach (char character in value)
    {
        if (character == single)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine(CountCharacter("Hello World!", 'o'));
