bool CheckPalindrome(int number)
{
    int current = number, sum = 0;

    while (current > 0)
    {
        int remainder = current % 10;
        sum = current * 10 + remainder;
        number /= 10;
    }

    return (number == sum);
}

if (CheckPalindrome(159))
{
    Console.WriteLine("Palindrome!");
}
else
{
    Console.WriteLine("Not Palindrome!");
}