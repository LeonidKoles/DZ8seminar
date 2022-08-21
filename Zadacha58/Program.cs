// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
void Zadacha58()
{
    int rows = 6;
    int columns = 6;
    int[,] array = new int[rows, columns];
    int row = 0;
    int column = 0;
    int chageRow = 0;
    int chageColumn = 1;
    int steps = columns;
    int turn = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[row, column] = i + 1;
        steps--;
        if (steps == 0)
        {
            steps = rows - 1 - turn / 2;
            int temp = chageRow;
            chageRow = chageColumn;
            chageColumn = -temp;
            turn++;
        }
        row += chageRow;
        column += chageColumn;
    }
    Console.WriteLine();
    PrintArray(array);
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
Zadacha58();