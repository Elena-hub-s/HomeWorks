using System;

namespace Pract1
{
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.

    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.

    //в) Добавить диалог с использованием switch демонстрирующий работу класса.


    //Фамилия выполняющего - Супрун
    class Complex2
    {
        public double im2;
        public double re2;

        public Complex2 Plus2(Complex2 x2)
        {
            Complex2 x3 = new Complex2
            {
                im2 = x2.im2 + im2,
                re2 = x2.re2 + re2
            };
            return x3;
        }
        public Complex2 Minus2(Complex2 x2)
        {
            Complex2 x3 = new Complex2
            {
                im2 = im2 - x2.im2,
                re2 = re2 - x2.re2
            };
            return x3;
        }
        public Complex2 Multi2(Complex2 x2)
        {
            Complex2 x3 = new Complex2
            {
                im2 = re2 * x2.im2 + im2 * x2.re2,
                re2 = re2 * x2.re2 - im2 * x2.im2
            };
            return x3;
        }
        public string Tosrt2()
        {
            return re2 + " + " + im2 + "i";
        }
    }
    internal struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public string Totsr()
        {
            return re + " + " + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //А)
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.Totsr());

            result = complex1.Minus(complex2);
            Console.WriteLine(result.Totsr());

            result = complex1.Multi(complex2);
            Console.WriteLine(result.Totsr());

            Console.WriteLine();
            //Б)
            Complex2 complex3 = new Complex2
            {
                re2 = 1,
                im2 = 1
            };

            Complex2 complex4 = new Complex2
            {
                re2 = 2,
                im2 = 2
            };

            Complex2 result2 = complex3.Plus2(complex4);
            Console.WriteLine(result2.Tosrt2());

            result2 = complex3.Minus2(complex4);
            Console.WriteLine(result2.Tosrt2());

            result2 = complex3.Multi2(complex4);
            Console.WriteLine(result2.Tosrt2());

            //В)
            while (true)
            {
                Console.WriteLine(@"Выберите действие с комплексными числами : 
+ = Сложение
- = Вычитание
* = умножение");
                char answer = Convert.ToChar(Console.ReadLine());

                Console.Write("Введите a : ");
                //complex4.re2 = Convert.ToInt32(Console.ReadLine());
                complex3.re2 = Convert.ToInt32(Console.ReadLine());
                complex3.im2 = complex3.re2;

                Console.Write("Введите b : ");
                complex4.im2 = Convert.ToInt32(Console.ReadLine());
                complex4.re2 = complex4.im2;
                switch (answer)
                {
                    case '+':
                        result2 = complex3.Plus2(complex4);
                        break;
                    case '-':
                        result2 = complex3.Minus2(complex4);
                        break;
                    case '*':
                        result2 = complex3.Multi2(complex4);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Попробуйте еще раз!");
                        break;
                }
                break;

            }
            Console.WriteLine(result2.Tosrt2());
            Console.ReadLine();
        }
    }
}