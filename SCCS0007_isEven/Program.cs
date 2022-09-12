Console.Clear();
Console.WriteLine("Введите любое число: ");
double isEven = Convert.ToDouble(Console.ReadLine());

if(isEven % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}

Console.ReadLine();
