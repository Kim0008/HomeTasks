// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Dozens;
Console.WriteLine("Введите число:");
Dozens = Convert.ToInt32(Console.ReadLine());
int DelSecondDigit(int Dozens)
{
    int nDozens = (Dozens / 10) % 10;
        return nDozens;
}
int N = DelSecondDigit(Dozens);
Console.WriteLine("Вторая цыфра: " + N);