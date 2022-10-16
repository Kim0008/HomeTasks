// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Random random = new Random();
int[,] arr = new int[random.Next(5, 10), random.Next(5, 10)];
Console.WriteLine("Случайный массив:");
void FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine("");
}
}

Console.WriteLine("---------------------------");
Console.WriteLine("Колличество столбцов - " + (arr.GetLength(0)));

void PrintArray(int[,] arr)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{sum / arr.GetLength(0)};");
}
Console.Write(" - средняя по столбцам!");
}

int[,] Yourmassiv = new int[random.Next(5, 10), random.Next(5, 10)];
FillArray(Yourmassiv);
PrintArray(Yourmassiv);

