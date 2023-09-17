// BUBBLE SORT

int[] BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

int[] arr = { 4, 7, 9, 1, -2, 5, 0, 3 };

Console.WriteLine($"Исходный массив: \n[ {string.Join(", ", arr)} ]");
int[] sortArr = BubbleSort(array: arr);
Console.WriteLine($"Отсортированный массив: \n[ {string.Join(", ", sortArr)} ]");