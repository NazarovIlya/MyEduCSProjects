
Console.Clear();

Console.WriteLine("Введите три целых числа через пробел:");
string[] array = Console.ReadLine().Split(' ', ',');

int a = Convert.ToInt32((string)array[0]);
int b = Convert.ToInt32((string)array[1]);
int c = Convert.ToInt32((string)array[2]);

int sum = a + b + c;
int product = a * b * c;

Console.WriteLine($"Сумма чисел {a}, {b}, {c} = {sum}");
Console.WriteLine($"Произведение чисел {a}, {b}, {c} = {product}");