Console.WriteLine("Задача 4: написать программу, которая обменивает элементы первой строки и последней строки");
Console.WriteLine();
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите левый предел диапазона элементов массива ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите правый предел диапазона элементов массива ");
int max = int.Parse(Console.ReadLine()!);
int[,] matr = new int[m, n];
int temp;

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = matrix[i, j];
                matrix[i, j] = matrix[(matrix.GetLength(0) - 1), j];
                matrix[(matrix.GetLength(0) - 1), j] = temp;
            }
        }
    }
}

FillArray(matr);
Console.WriteLine("Вот так выглядит исходный массив: ");
PrintArray(matr);
Console.WriteLine();
ChangeArray(matr);
Console.WriteLine("Вот так выглядит изменённый массив: ");
PrintArray(matr);