bool CheckPrime(int number)
{
    if (number < 2)
    {
        return false;
    }
    else if (number == 2)
    {
        return true;
    }
    else if (number % 2 == 0)
    {
        return false;
    }
    for (int i = 3; i <= Math.Sqrt(number); i += 2)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}

if (CheckPrime(159))
{
    Console.WriteLine("Prime");
}
else
{
    Console.WriteLine("Not Prime");
}