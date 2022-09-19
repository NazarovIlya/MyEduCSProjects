Console.Clear();
Console.WriteLine("Hello, user!");
int count = 10;
for (int i = 0; i <= count; i++)
{
	for (int j = 0; j < i; j++)
	{
        Console.Write("#");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = count; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}