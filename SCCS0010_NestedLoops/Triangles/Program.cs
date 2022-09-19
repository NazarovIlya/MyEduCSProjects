Console.Clear();
Console.WriteLine("Hello, user!");
int count = 10;
for (int i = 0; i <= count; i++)
{
	for (int j = 0; j < i; j++)
	{
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < count; i++)
{
    for (int j = count; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i <= count; i++)
{
    for (int j = count; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i <= count; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(" ");
    }
    for (int j = count; j > i; j--)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
