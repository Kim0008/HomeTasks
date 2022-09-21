//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
int n, i;
i = 1;
Console.WriteLine("Введите число:");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
    {
    i += 1;
    }
while (i <= n)
    {
    Console.WriteLine(i);
    i += 2;
    }