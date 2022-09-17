void FillArray(int [,] array, int startNumber = 0, int finishNumber = 10)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    finishNumber++;
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++) 
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); 
        }
    Console.WriteLine();
    }
}
void Zadacha58()
{
    // Задача 58: Задайте две матрицы. Напишите программу, которая будет
    // находить произведение двух матриц.
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 5);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    int[,] matrixA = new int[size, size];
    int[,] matrixB = new int[size, size];
    FillArrayRandomNumbers(matrixA);
    FillArrayRandomNumbers(matrixB);
    int[,] matrixC = new int[size, size];
}