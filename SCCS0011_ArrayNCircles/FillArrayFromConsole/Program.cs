// Заполнить массив с клавитуры 

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
int[] FillArray()
{
    int[] array = new int[countNumbers];
    for (int i = 0; i < countNumbers; i++)
    {
        Console.Write($"Введите значение для элемента массива {i + 1}:\t");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] arr = FillArray();
PrintArray(arr);

//int numbers[] = Console.ReadLine()