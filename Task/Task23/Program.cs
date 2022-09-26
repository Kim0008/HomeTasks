// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber()
{
    Console.Write("Введите Число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void GetN(int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.Write(" : " + Math.Pow((count), 3));
        count++;      
    }
}

GetN(GetNumber());