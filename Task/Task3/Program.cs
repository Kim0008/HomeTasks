//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int n;
Console.WriteLine("Введите число:");
n = Convert.ToInt32(Console.ReadLine());
    if (n % 2 == 1)
  {   
    Console.WriteLine(" Нет!");
  }
    else
  {
    Console.WriteLine("Да!");
  }