// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int DayWeek;
Console.WriteLine("Введите число от 1 до 7: ");
DayWeek = Convert.ToInt32(Console.ReadLine());
int Week(int DayWeek)
{
    if (DayWeek == 6)
    {
        Console.Write(" это выходной: ");

    }

    if (DayWeek == 7)
    {
        Console.Write(" это выходной: ");

    }
    else
    {
        Console.Write("это не выходной: ");
    }
    return DayWeek;
}
int nWeek = Week(DayWeek);
Console.WriteLine(nWeek);

