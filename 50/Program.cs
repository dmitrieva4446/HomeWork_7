// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2        1 2 -> 4
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 1000);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void AdressLookupMatrix(int[,] matrix)
{
    Console.Write("Введите позицию элемента в двумерном массиве через пробел: ");
    int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int x = array[0];
    int y = array[1];

    if (x < 0 || y < 0 || x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
        Console.WriteLine("Такого числа в массиве нет.");
    else Console.WriteLine(matrix[x, y]);
}

Console.Clear();
Console.Write("Введите размеры матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
AdressLookupMatrix(matrix);