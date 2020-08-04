using System;

namespace ThirdLesson_HomeWork_Example2
{
    class Program
    {
            //С клавиатуры вводятся числа, пока не будет введён 0 
            //(каждое число в новой строке). 
            //Требуется подсчитать сумму всех нечётных положительных чисел.
            //Сами числа и сумму вывести на экран, используя tryParse.





       //Фамилия выполняющего - Супрун
        static void Main(string[] args)
        {
            int sum = 0;

            while(true)
            {
                Console.Write("Введите число или 0 для выхода : ");

                if (int.TryParse(Console.ReadLine(), out int a) && a != 0)
                {
                    if (a % 2 != 0 && a >= 0) sum += a;
                }
                else if (a == 0) break;
                else continue;
            }
            Console.WriteLine($"\nСумма всех нечетных положительных чисел = {sum}");
            Console.ReadLine();
        }
    }
}
