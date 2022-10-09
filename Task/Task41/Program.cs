// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько будет чисел?: ");
int numberofDigits = Convert.ToInt32(Console.ReadLine());
int[] positiveNumbers = new int[numberofDigits];

void Numbers(int numberofDigits)
{
    for (int i = 0; i < numberofDigits; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        positiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Exception(int[] positiveNumbers)
{
    int count = 0;
    for (int i = 0; i < positiveNumbers.Length; i++)
    {
        if (positiveNumbers[i] > 0) count += 1;
    }
    return count;
}
Numbers(numberofDigits);
Console.WriteLine($"Введено чисел больше 0: {Exception(positiveNumbers)} ");