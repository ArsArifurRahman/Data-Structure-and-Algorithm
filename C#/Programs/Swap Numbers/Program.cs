void NumberSwapper(int x, int y)
{
    x = x ^ y;
    y = x ^ y;
    x = x ^ y;
}

int a = 159, b = 357;

Console.WriteLine($"Before swap, value of a is {a}, value of b is {b}");

NumberSwapper(a, b);

Console.WriteLine($"After swap, value of a is {a}, value of b is {b}");