// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(min, max);
        }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ChangingLines(int[,] arr)
{
    int[] tempArray = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        tempArray[i] = arr[0, i];
    }
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
    }
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        arr[arr.GetLength(0) - 1, i] = tempArray[i];
    }
}

int[,] newArray = GetArray(4, 4, 1, 10);
PrintArray(newArray);
ChangingLines(newArray);
Console.WriteLine();
PrintArray(newArray);
