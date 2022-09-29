// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int R()
{
    Console.Write("Введите число:");
    return Convert.ToInt32(Console.ReadLine());
}

int NL(int a)
{
    int dex = 0;
    while (a > 0)
    {
        a /= 10;
        dex++;
    }
    return dex;
}

void SumN(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine("Сумма: " + sum);
}

int number = R();
int len = NL(number);
SumN(number, len);