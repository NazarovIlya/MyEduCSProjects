
Console.Clear();

double a = 0,
       b = 0,
       result = 0;

Console.WriteLine("Введите первое число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToDouble(Console.ReadLine());
result = (a + b) / 2;
Console.WriteLine($"Среднее арифметическое {a} и {b} = {result}");
Console.ReadLine();
