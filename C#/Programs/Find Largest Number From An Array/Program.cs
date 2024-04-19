int LargestElement(int[] array)
{
    int largest = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > largest)
        {
            largest = array[i];
        }
    }

    return largest;
}

int[] array = { 159, 357, 555, 258, 456 };
Console.WriteLine(LargestElement(array));