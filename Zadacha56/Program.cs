// Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов.
void Zadacha56()
{
    Console.WriteLine("Введите количество строк и нажмите Enter");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов и нажмите Enter");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] array = new int[rows, columns];

    FillArray(array);
    PrintArray(array);


    int[] ar = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            ar[i] += array[i, j];

        }
    }
    int minSum = ar[0];
    int minInd = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (minSum > ar[i])
        {
            minSum = ar[i];
            minInd = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов ровна {minSum} строка номер {minInd + 1}");


    
}
void FillArray(int[,] array, int startNum = 0, int finishNum = 10)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = random.Next(startNum, finishNum);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Zadacha56();