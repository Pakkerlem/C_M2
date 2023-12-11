//  Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
//  Под удалением понимается создание нового двумерного массива без строки и столбца

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] newrray = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newrray[i, j] = rand.Next(min, max);
        }
    }
    return newrray;
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
int[,] DeletionAtIntersection(int[,] arr)
{
    int minE = int.MaxValue;
    int m = 0;
    int n = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < minE)
            {
                minE = arr[i, j];
                m = i;
                n = j;
            }

        }
    }
    // Console.WriteLine($"Координаты + {m} + {n} + {minE} + ");
    int[,] nArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int a = 0;
    int b = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != m)
        {
            b = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != n)
                {
                    nArray[a, b] = arr[i, j];
                    b++;
                }

            }
            a++;
        }
    }
    return nArray;
}
int[,] newArray = GetArray(4, 4, 1, 100);
PrintArray(newArray);
int[,] emptyArray = new int[3, 3];
emptyArray = DeletionAtIntersection(newArray);
Console.WriteLine();
PrintArray(emptyArray);