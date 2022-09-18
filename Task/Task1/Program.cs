// Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int numberA, numberB;
         Console.WriteLine("Введите два числа : ");
         numberA = Convert.ToInt32(Console.ReadLine());
         numberB = Convert.ToInt32(Console.ReadLine());
         if (numberA > numberB)
         {
             Console.WriteLine(("Наибольшее число: ") + numberA);
         }
         else
         {
             Console.WriteLine(("Наибольшее число: ") + numberB);
         }
         if (numberA < numberB)
         {
             Console.WriteLine(("Наименьшее число: ") + numberA);
         }
         else
         {
             Console.WriteLine(("Наименьшее число: ") + numberB);
         }