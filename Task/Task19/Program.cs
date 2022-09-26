// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(int n)
{
    if (n >= 10000)
    {
        int Nunber = n / 10000;
        int Nunber2 = n % 10;

        if (Nunber == Nunber2)
        {
            n = n / 10;
            int Nunber1 = n / 100;
            int Nunber3 = n % 10;
            if (Nunber1 == Nunber3);
            Console.WriteLine("Да, это палиндром.");
        }
        else
            Console.WriteLine("Нет, это не палиндром!");

    }
    else
        Console.WriteLine("Число не соответствует условию!!!");
}

Console.Write("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());
Palindrom(n);