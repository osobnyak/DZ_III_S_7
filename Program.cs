//Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("сколько строк будет в массиве? ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("сколько столбцов будет в массиве? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(1, 10);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("какой номер элемента в строке? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("какой номер элемента в столбце? ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (a > m || b > n)
{ 
    Console.WriteLine("количество строк или столбцов меньше, чем ваше значение."); 
}
else 
{
    a = a - 1;
    b = b - 1;
    Console.WriteLine($"значение элемента = {num[a, b]}");
}