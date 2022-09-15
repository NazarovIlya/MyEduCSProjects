using System.Xml.Linq;

Console.Clear();
int firstDiapasonNumber = 0;
int secondDiapasonNumber = 0;
while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Введите число 1:");
        firstDiapasonNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 2:");
        secondDiapasonNumber = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Не удалось преобразовать строку в число.");
        continue;
    }
    int evenCount = 0;
    int oddCount = 0;
    int sumEven = 0;
    int sumAdd = 0;
    while (firstDiapasonNumber <= secondDiapasonNumber)
    {
        if (firstDiapasonNumber % 2 == 0)
        {
            evenCount++;
            sumEven += firstDiapasonNumber;
            firstDiapasonNumber++;
        }
        else
        {
            oddCount++;
            sumAdd += firstDiapasonNumber;
            firstDiapasonNumber++;
        }
    }
    firstDiapasonNumber -= (evenCount + oddCount);
    Console.WriteLine($"В диапазоне от {firstDiapasonNumber} до {secondDiapasonNumber} содержится {evenCount} четных чисел и {oddCount} нечетных.");
    Console.WriteLine($"Сумма всех четных чисел в указанном диапазоне = {sumEven}, а нечетных = {sumAdd}");   
    Console.ReadLine();
}



