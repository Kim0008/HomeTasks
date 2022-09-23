// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
//Методом

int GetNumber()
{
 Console.WriteLine("Введите число!");
 return Convert.ToInt32(Console.ReadLine()); 
}

bool CheckMod(int a, int mod)
{
 return (a % mod == 0);
}

int a = GetNumber();

if (CheckMod(a,7) && CheckMod(a,23))
 Console.WriteLine("Верно!");
else
 Console.WriteLine("Не верно!");

//Линейно

//Console.WriteLine("Введите число: ");
//int multiple = Convert.ToInt32(Console.ReadLine());

//bool result;
//bool multiple7;
//bool multiple23;
//if (multiple % 7 == 0)
//{
//    multiple7 = true;
//}
//else
//{
//    multiple7 = false;
//}
//if (multiple % 23 == 0)
//{
//    multiple23 = true;
//}
//else
//{
//    multiple23 = false;
//}
//if (multiple7 == true && multiple23 == true);
//{
//    result = true;
//}
//else
//{
//    result = false;
//}

//if (result == true) ;
//Console.WriteLine("кратно!");

