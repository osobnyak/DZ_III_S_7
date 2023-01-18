int[,] num = new int[3, 4];
double sum1 = 0;
double sum2 = 0;
double sum3 = 0;
double sum4 = 0;

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

for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j == 0; j++)
    {
        sum1 = (sum1 + num[i, j]);
    }
    for (int j = 1; j == 1; j++)
    {
        sum2 = (sum2 + num[i, j]);
    }
    for (int j = 2; j == 2; j++)
    {
        sum3 = (sum3 + num[i, j]);
    }
    for (int j = 3; j == 3; j++)
    {
        sum4 = (sum4 + num[i, j]);
    }

}
Console.Write($"{Math.Round((sum1/3), 2)}; ");
Console.Write($"{Math.Round((sum2/3), 2)}; ");
Console.Write($"{Math.Round((sum3/3), 2)}; ");
Console.WriteLine($"{Math.Round((sum4/3), 2)}. ");