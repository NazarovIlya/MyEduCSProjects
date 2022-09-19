Console.WriteLine("Hello, user!");
int[,] GetRandomArray(int rows, int columns)
{
    Random random = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int  i = 0;  i < rows;  i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = random.Next(100);
        }
    }
    return resultArray;
}

void PrintArray2D(int [,] matrix)
{
    for (int  i = 0;  i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] >= 0)
                Console.Write($" {matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}

int rows = 0;
int columns = 0;
try
{
    Console.WriteLine("Input count of rows: ");
    rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input count of columns: ");
    columns = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Output error!");
}

Console.Clear();
int[,] Array2D = GetRandomArray(rows, columns);
PrintArray2D(Array2D);