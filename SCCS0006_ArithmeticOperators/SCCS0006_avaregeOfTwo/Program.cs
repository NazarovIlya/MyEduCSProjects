
Console.Clear();

double firstValue = 0,
       secondValue = 0,
       result = 0;

Console.WriteLine("Введите первое число: ");
firstValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
secondValue = Convert.ToDouble(Console.ReadLine());
result = (firstValue + secondValue) / 2;
Console.WriteLine($"Среднее арифметическое {firstValue} и {secondValue} = {result}");
Console.ReadLine();
