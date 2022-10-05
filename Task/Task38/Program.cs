// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());


void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000)) % 10;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();

    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > max)
        {
            max = arr[j];
        }
        if (arr[j] < min)
        {
            min = arr[j];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}


double[] Yourmassiv = new double[numbers];
FillArray(Yourmassiv);
PrintArray(Yourmassiv);


