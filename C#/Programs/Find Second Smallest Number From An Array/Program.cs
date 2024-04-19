int SecondSmallestElement(int[] array)
{
    if (array.Length < 2)
    {
        throw new ArgumentException("Array must contain at least two elements.");
    }

    int smallest = int.MaxValue, secondSmallest = int.MaxValue;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < smallest)
        {
            smallest = array[i];
        }
        else if (array[i] < secondSmallest && array[i] > smallest)
        {
            secondSmallest = array[i];
        }
    }

    return secondSmallest;
}

int[] array = { 159, 357, 555, 258, 456 };
Console.WriteLine(SecondSmallestElement(array));
