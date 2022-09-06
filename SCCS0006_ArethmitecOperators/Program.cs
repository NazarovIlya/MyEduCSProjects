
Console.Clear();
double a = 0,
       b = 0,
       result = 0;

Console.WriteLine("Введите первое число для сложения: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число для сложения: ");
b = Convert.ToDouble(Console.ReadLine());
result = a + b;
Console.WriteLine(result);


Console.WriteLine("Введите первое число для вычитания");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число для вычитания: ");
b = Convert.ToDouble(Console.ReadLine());
result = a - b;
Console.WriteLine(result);

Console.WriteLine("Введите первое число для умножения: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число для умножения: ");
b = Convert.ToDouble(Console.ReadLine());
result = a * b;
Console.WriteLine(result);

Console.WriteLine("Введите первое число для деления: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число для деления: ");
b = Convert.ToDouble(Console.ReadLine());
result = a / b;
Console.WriteLine(result);

Console.WriteLine("Введите первое число для деления по модулю: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число для деления по модулю: ");
b = Convert.ToDouble(Console.ReadLine());
result = a % b;
Console.WriteLine(result);