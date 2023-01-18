//Задача 47. 
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] num = new double[3, 4];

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = (new Random().NextDouble() + new Random().Next(-9, 10));
        Console.Write($"{Math.Round(num[i, j], 1)} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
