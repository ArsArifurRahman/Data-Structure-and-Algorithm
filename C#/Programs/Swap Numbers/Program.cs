void NumberSwapper(int x, int y)
{
    Console.WriteLine($"Before swap, value of x is {x}, value of y is {y}");
    x = x ^ y;
    y = x ^ y;
    x = x ^ y;
    Console.WriteLine($"After swap, value of a is {x}, value of b is {y}");
}

int a = 159, b = 357;
NumberSwapper(a, b);