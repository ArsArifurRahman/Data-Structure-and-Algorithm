int SmallestElement(int[] array)
{
    int smallest = array[0];

    for (int i = 1; i <= array.Length; i++)
    {
        if (array[i] < smallest)
        {
            smallest = array[i];
        }
    }

    return smallest;
}

int[] array = { 159, 357, 555, 258, 456 };
Console.WriteLine(SmallestElement(array));