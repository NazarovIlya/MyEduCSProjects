// COUNTING SORT

// Only digits sort
void CountingSortDigits(int[] array)
{
    int[] counters = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        counters[array[i]]++;       // int number = array[i];
                                    // counters[number]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            array[index] = i;
            index++;
        }
    }
}



int[] myArr = new[] { 0, 2, 3, 2, 1, 5, 9, 1, 1 };
Console.WriteLine($"Исходный массив: [ {string.Join(", ", myArr)} ]");
CountingSortDigits(myArr);
Console.WriteLine($"Отсортированный массив: [ {string.Join(", ", myArr)} ]");
