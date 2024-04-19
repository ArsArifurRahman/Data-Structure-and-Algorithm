int SecondLargestElement(int[] array)
{
    if (array.Length < 2)
    {
        throw new ArgumentException("Array must contain at least two elements");
    }

    int largest = array[0];
    int secondLargest = int.MinValue;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > secondLargest && array[i] < largest)
        {
            secondLargest = array[i];
        }
    }

    return secondLargest;
}

int[] array = { 159, 357, 555, 258, 456 };
Console.WriteLine(SecondLargestElement(array));