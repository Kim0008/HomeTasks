// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[lines, columns];
RandomNumbers(numbers);
Printmas(numbers);

void RandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(1, 1000)) / 10;
        }
    }
}

void Printmas(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write('[');
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(']');
        Console.WriteLine();
    }
}
