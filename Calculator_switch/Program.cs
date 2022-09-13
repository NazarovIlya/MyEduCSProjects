Console.Clear();

double firstValue = 0;
double secondValue = 0;
double result = 0;
string action = string.Empty;

while (true)
{
    Console.Clear();
    Console.WriteLine("Введите число 1:");
    firstValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число 1:");
    secondValue = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Выберите действие: '+', '-', '*', '/'");
    action = Console.ReadLine();

    switch (action)
    {
        case "+":
            result = firstValue + secondValue;
            break;
        case "-":
            result = firstValue - secondValue;
            break;
        case "*":
            result = firstValue * secondValue;
            break;
        case "/":
            {
                if (secondValue == 0)
                    result = 0;
                else
                result = firstValue / secondValue;
            }
            break;
        default:
            Console.WriteLine("Error! Can't do action");
            break;
    }

    Console.Write($"{result}");
    Console.ReadLine();
}