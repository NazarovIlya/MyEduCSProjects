// Заполнить массив с клавитуры 
// Вывести массив в обратном порядке

using System;

Console.Clear();

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
        else
            break;
    }
    Console.WriteLine(" ]");
}

void PrintReverseArray(int[] array)
{
    Console.Write("[ ");
    for (int i = array.Length - 1; i >= 0; i--)
    {
        Console.Write(array[i]);
        if (i != 0)
            Console.Write(", ");
        else
            break;
    }
    Console.WriteLine(" ]");
}

int GetSumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] FillArray()
{
    Console.Write("Введите колчиство элементов массива:\t");
    int countNumbers = 0;
    try
    {
        countNumbers = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Ошибка ввода.");
    }
    int[] array = new int[countNumbers];
    for (int i = 0; i < countNumbers; i++)
    {
        Console.Write($"Введите значение для элемента массива {i + 1}:\t");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetMininmum(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}

int[] arr = FillArray();
PrintArray(arr);
PrintReverseArray(arr);
double resultSum = GetSumEven(arr);
Console.WriteLine($"Сумма значений элементов массива: {resultSum}");
int min = GetMininmum(arr);
Console.WriteLine($"Минимальное значение: {min}");
