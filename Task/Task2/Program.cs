//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c, max;
Console.WriteLine("Привет!");
Console.WriteLine("Введите три числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.Write("Наибольшее из введенных чисел: ");
Console.WriteLine(max);