Console.Clear();
Console.WriteLine("Hello, User!");
int firstValue = 0;
int secondValue = 0;
Console.WriteLine("Введите количество итераций для первого цикла: ");
try
{
    firstValue = Convert.ToInt32(Console.ReadLine());
}
catch 
{
    Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine("Введите количество итераций для второго цикла: ");
try
{
    secondValue = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка ввода!");
}
Console.Clear();
for (int i = 0; i < firstValue; i++)
{
    Console.WriteLine($"Итерация первого цикла #{i}");
    for (int j = 0; j < secondValue; j++)
    {
        Console.WriteLine($"\tИтерация второго цикла #{j}");
        System.Threading.Thread.Sleep(100);
    }
}
Console.ReadLine();