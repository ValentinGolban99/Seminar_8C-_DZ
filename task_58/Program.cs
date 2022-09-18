int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
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
void MultiplyMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
  for (int i = 0; i < matrixC.GetLength(0); i++)
  {
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixA.GetLength(1); k++)
      {
        sum += matrixA[i,k] * matrixB[k,j];
      }
      matrixC[i,j] = sum;
    }
  }
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
Random random = new Random();
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, p];
int[,] matrixC = new int[m, p];
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();
MultiplyMatrix(matrixA, matrixB, matrixC);
PrintArray(matrixC);

