//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();

    int count = 0;
    for (int j = 0; j < arr.Length; j++)
        if (arr[j] % 2 == 0)
            count++;

    Console.WriteLine($"всего {arr.Length} чисел, {count} из них чётные");
}

int[] Yourmassiv = new int[numbers];
FillArray(Yourmassiv);
PrintArray(Yourmassiv);
