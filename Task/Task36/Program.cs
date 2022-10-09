// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();

    int sum = 0;

    for (int j = 1; j < arr.Length; j += 2)
    {
        sum = sum + arr[j];

    }

    Console.WriteLine($"всего {arr.Length} чисел, сумма на нечетных позициях = {sum}");
}

int[] Yourmassiv = new int[numbers];
FillArray(Yourmassiv);
PrintArray(Yourmassiv);