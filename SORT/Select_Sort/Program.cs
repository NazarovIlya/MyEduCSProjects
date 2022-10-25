// Сортировка выбором


int[] arr = { 6, 4, 9, -5, 1, -19, 600, -30, 8 };

int[] SelectSort(int[] array)
{
    for (int i = 0; i < array.Length - 2; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length - 1; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }
        int temp = 0;
        temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
    }
    return array;
}

int[] sortArray = SelectSort(arr);
Console.WriteLine($"[ {string.Join(", ", sortArray)} ]");
