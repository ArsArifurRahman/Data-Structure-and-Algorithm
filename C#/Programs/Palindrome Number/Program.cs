bool CheckPalindrome(int number)
{
    int current = number, reverse = 0;

    while (number > 0)
    {
        int remainder = number % 10;
        reverse = reverse * 10 + remainder;
        number /= 10;
    }

    return current == reverse;
}

if (CheckPalindrome(159))
{
    Console.WriteLine("Palindrome!");
}
else
{
    Console.WriteLine("Not Palindrome!");
}