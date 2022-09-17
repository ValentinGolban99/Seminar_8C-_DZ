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
void Zadacha56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите
    // программу, которая будет находить строку с наименьшей суммой элементов.
    Random random = new Random();
    int rows = random.Next(3, 5);
    int columns = random.Next(3, 5);
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    int minsum = Int32.MaxValue;
    int indexLine = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }

    Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
}
Zadacha56();