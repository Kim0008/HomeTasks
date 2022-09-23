// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Ed;
Console.WriteLine("Введите число:");
Ed = Convert.ToInt32(Console.ReadLine());
int DelSecondDigit(int Ed)
{
    int nDozens = (Ed / 10) % 10;
        return nDozens;

 if (Ed <= 99)
    {
    Console.WriteLine("Третьей цифры нет!");
    }
else
    {
    Console.WriteLine();
    }
}
int N = DelSecondDigit(Ed);
Console.WriteLine("Третья цыфра: " + N);

