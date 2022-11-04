// COUNTING SORT

// Only digits sort
int[] CountingSortDigits(int[] array)
{
    int[] arraySorted = new int[array.Length];
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
            arraySorted[index] = i;
            index++;
        }
    }
    return arraySorted;
}

// Only integer numbers sort
int[] CountingSortExtended(int[] array)
{
    int max = array.Max();
    int min = array.Min();
    int offset = -min;
    int[] arraySorted = new int[array.Length];
    int[] counters = new int[max + offset + 1];
    for (int i = 0; i < array.Length; i++)
    {
        counters[array[i] + offset]++;   // int number = array[i];
                                         // counters[number]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            arraySorted[index] = i - offset;
            index++;
        }
    }
    return arraySorted;
}



int[] myArrDigits = new[] { 0, 2, 3, 2, 1, 5, 9, 1, 1 };
int[] myArrNumbers = new[] { 6, 31, 13, -13, 2, 7, 1, 6, 2, 1, 46, 24 };
Console.WriteLine($"Исходный массив: [ {string.Join(", ", myArrDigits)} ]");
int[] resArrDigits = CountingSortDigits(myArrDigits);
Console.WriteLine($"Отсортированный массив: [ {string.Join(", ", resArrDigits)} ]");
Console.WriteLine();

Console.WriteLine($"Исходный массив: [ {string.Join(", ", myArrNumbers)} ]");
int[] resArrNumbers = CountingSortExtended(myArrNumbers);
Console.WriteLine($"Отсортированный массив: [ {string.Join(", ", resArrNumbers)} ]");
