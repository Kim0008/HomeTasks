// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// если число трехзначное!!!
int Ed;
Console.WriteLine("Введите трехзначное число:");
Ed = Convert.ToInt32(Console.ReadLine());
int DelSecondDigit(int Ed)
{
    int nDozens = Ed % 10;
    
        return nDozens;

 }
int N = DelSecondDigit(Ed);
Console.WriteLine("Третья цыфра: " + N);

