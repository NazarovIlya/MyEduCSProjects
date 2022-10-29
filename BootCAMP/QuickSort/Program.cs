// QUICK SORT

int[] QuickSort(int[] array, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return array;
    int pivot = GetPivotIndex(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivot - 1);
    QuickSort(array, pivot + 1, maxIndex);
    return array;
}


int GetPivotIndex(int[] array, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (array[i] < array[maxIndex])
        {
            pivotIndex++;
            Swap(array, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(array, pivotIndex, maxIndex);
    return pivotIndex;
}


void Swap(int[] array, int leftValue, int rightValue)
{
    int temp = array[leftValue];
    array[leftValue] = array[rightValue];
    array[rightValue] = temp;
}


Console.Clear();
int[] arr = { 8, 0, -4, 7, -2, 2, -9, 3 };
Console.WriteLine($"Исходный массив: \t[ {string.Join(", ", arr)} ]");
int[] res = QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine($"Отсортированный массив: \t[ {string.Join(", ", res)} ]");