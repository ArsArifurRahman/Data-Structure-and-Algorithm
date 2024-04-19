int RecursiveFactorial(int number)
{
    if (number == 0)
    {
        return 1;
    }

    return number * RecursiveFactorial(number - 1);
}

int IterativeFactorial(int number)
{
    int factorial = 1;

    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }

    return factorial;
}

Console.WriteLine(RecursiveFactorial(5));
Console.WriteLine(IterativeFactorial(5));