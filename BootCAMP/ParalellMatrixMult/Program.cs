Console.Clear();

const int N = 1000;
const int THREADS_NUMBER = 8;

int[,] serialMatrixMultRes = new int[N, N];
int[,] threadMatrixMultRes = new int[N, N];

int[,] firstMatrix = FillMatrix(N, N);
int[,] secondMatrix = FillMatrix(N, N);

SerialMatrixMult(firstMatrix, secondMatrix);
PrepareParallelMult(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMatrixMultRes, threadMatrixMultRes));

int[,] FillMatrix(int row, int column)
{
    Random random = new Random();
    int[,] resMatrix = new int[row, column];
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            resMatrix[i, j] = random.Next(-100, 100);
        }
    }
    return resMatrix;
}


void SerialMatrixMult(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        throw new System.Exception("Нельзя перемножать матрицы подобных размерностей.");
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                serialMatrixMultRes[i, j] += matrixA[i, j] * matrixB[i, k];
            }
        }
    }
}


void ParallelMatrixMult(int[,] matrixA, int[,] matrixB, int startPos, int endPos)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        throw new System.Exception("Нельзя перемножать матрицы подобных размерностей.");
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                threadMatrixMultRes[i, j] += matrixA[i, j] * matrixB[i, k];
            }
        }
    }
}


void PrepareParallelMult(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
        throw new System.Exception("Нельзя перемножать матрицы подобных размерностей.");
    int eachThreadCalc = N / THREADS_NUMBER;
    var threadsList = new List<Thread>();
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        if (i == THREADS_NUMBER - 1)
            endPos = N;
        threadsList.Add(new Thread(() => ParallelMatrixMult(matrixA, matrixB, startPos, endPos)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}


bool EqualityMatrix(int[,] fMatrix, int[,] sMatrix)
{
    bool res = true;
    for (int i = 0; i < fMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fMatrix.GetLength(1); j++)
        {
            res = res && (fMatrix[i, j] == sMatrix[i, j]);
        }
    }
    return res;
}






