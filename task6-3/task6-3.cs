Console.WriteLine("Задача 3: в двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");
Console.WriteLine();
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите левый предел диапазона элементов массива ");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите правый предел диапазона элементов массива ");
int max = int.Parse(Console.ReadLine()!);


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
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
                // int temp =  matrix[i, j];
                // temp = temp*temp;
                // matrix[i, j] = temp;
            }

        }
    }
}

int[,] matr = new int[m, n];

FillArray(matr);
Console.WriteLine("Вот так выглядит исходный массив: ");
PrintArray(matr);
Console.WriteLine();
Console.WriteLine("Вот так выглядит изменённый массив: ");
ChangeArray(matr);
PrintArray(matr);