Console.Clear();
Console.WriteLine("Hello, User!");
int height = 0;
int wigth = 0;
Console.WriteLine("Введите высоту прямоугольника: ");
try
{
    height = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine("Введите ширину прямоугольника: ");
try
{
    wigth = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка ввода!");
}
Console.Clear();
for (int i = 0; i < height; i++)
{
    for (int j = 0; j < wigth; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
Console.ReadLine();