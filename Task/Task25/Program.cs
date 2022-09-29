// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int numberA = In("Введите число A: ");
int numberB = In("Введите число B: ");
AB(numberA, numberB);

void AB(int a, int b)
{
 int result = 1;
 for (int i = 1; i <= b; i++)
    {
 result = result * a;
    }
 Console.WriteLine("Число A в степени B: " + result);
}

int In(string message)
{
 Console.WriteLine(message);
 return Convert.ToInt32(Console.ReadLine());
}
