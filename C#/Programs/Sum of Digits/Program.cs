int SumOfDigits(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int remainder = number % 10;
        sum += remainder;
        number /= 10;
    }

    return sum;
}

Console.WriteLine(SumOfDigits(159));