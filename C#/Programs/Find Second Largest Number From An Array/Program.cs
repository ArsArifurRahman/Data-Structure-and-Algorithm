int SecondLargestElement(int[] array)
{
    int largest = 0;
    int secondLargest = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > largest)
        {
            secondLargest = largest;
            largest = array[i];
        }
        else if (array[i] > secondLargest)
        {
            secondLargest = array[i];
        }
    }

    return secondLargest;
}

int[] array = { 159, 357, 555, 258, 456 };
Console.WriteLine(SecondLargestElement(array));