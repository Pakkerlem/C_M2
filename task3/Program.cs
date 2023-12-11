// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

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
// void SmallestSumElements(int[,] arr)
// {
//     int[] tempArray = new int[arr.GetLength(1)];

//     for (int j = 0; j < arr.GetLength(1); j++)
//         {

//         }


// }

void SmallestSumElements(int[,] arr)
{
    int minSum = int.MaxValue;
    int minIndex = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int Sum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Sum += arr[i, j];
        }

        if (Sum < minSum)
        {
            minSum = Sum;
            minIndex = i;
        }
    }
    Console.Write(minIndex);
}

int[,] newArray = GetArray(4, 5, 1, 10);
PrintArray(newArray);
SmallestSumElements(newArray);