int RecursiveFibonacci(int number)
{
    if (number <= 1)
    {
        return number;
    }

    return RecursiveFibonacci(number - 1) + RecursiveFibonacci(number - 2);
}

Console.WriteLine(RecursiveFibonacci(10));