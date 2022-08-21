// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
void Zadacha54 ()
{
        Console.WriteLine("Введите количество строк и нажмите Enter");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов и нажмите Enter");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] array = new int[rows, columns];

    FillArray(array);
    PrintArray(array);
    Console.WriteLine();

    for (int i = 0; i< rows; i++)
    {
        for (int j = columns -1; j >= 0; j--)
        {
            for (int k = 0; k < j; k++)
            {
                if (array[i,k] < array[i,k + 1])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i, k+1];
                    array[i, k + 1] = temp;                }
            }
        }
    }
    PrintArray(array);

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
Zadacha54();