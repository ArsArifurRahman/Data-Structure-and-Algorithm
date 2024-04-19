bool CheckArmstrong(int number)
{
    int current = number, sum = 0;

    while (current > 0)
    {
        int remainder = current % 10;
        sum = (int)(sum + Math.Pow(remainder, 3));
        current /= 10;
    }

    return (number == sum);
}

if (CheckArmstrong(159))
{
    Console.WriteLine("Armstrong!");
}
else
{
    Console.WriteLine("Not Armstrong!");
}