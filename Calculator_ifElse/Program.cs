Console.Clear();

double firstValue = 0;
double secondValue = 0;
double result = 0;
string action = string.Empty;

Console.WriteLine("Введите число 1:");
firstValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 1:");
secondValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Выберите действие: '+', '-', '*', '/'");
action = Console.ReadLine();

if (action == "+")
{
	result = firstValue + secondValue;
}
else if (action == "-")
{
	result = firstValue - secondValue;
}
else if (action == "*")
{
	result = firstValue * secondValue;
}
else if (action == "/")
{
	if (secondValue == 0)
        result = 0;
    result = firstValue / secondValue;
	

}

Console.WriteLine(result);
Console.ReadKey();
Environment.Exit(0);