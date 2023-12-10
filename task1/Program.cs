// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

void Elementoutput(int[,] arr)
{
    Console.WriteLine("Введите координаты элемента в массива");
    
    int i = Convert.ToInt32(Console.ReadLine());
    int j = Convert.ToInt32(Console.ReadLine());
    

    if (i<arr.GetLength(0) && j<arr.GetLength(1))
    {
        Console.WriteLine($"Элемент массива: {arr[i, j]}");
    }
    else
    {
        Console.WriteLine("Элемент не найден");
    }
}

int[,] newArray = GetArray(3, 3, 1, 10);
PrintArray(newArray);
Elementoutput(newArray);