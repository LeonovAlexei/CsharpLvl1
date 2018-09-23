//                    Леонов Алексей
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Lesson2
    {
        /// <summary>
        /// Метод Minimum принимает 3 значения и возвращает минимальное из них
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private static  double Minimum (double a,double b, double c)
        {
            double min;
            if (a < b && a < c) return min = a; min = b;
            return min < c ? min : (min = c);
        }
        /// <summary>
        /// Метод принимает 1 число и возвращает количество цифр в нем.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int DigitsInNumber(int n)
        {
            int i;
            for (i = 0; n != 0; i++)
            {
                n = n / 10;
            }
            return i;
        }
        static void Main(string[] args)
        {
            //                    
            //1.Написать метод, возвращающий минимальное из трёх чисел.
            double a, b, c;
            Console.Write("Введите три числа \nВведите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Минимальное число:{ Minimum(a, b, c)}");
            Console.Write($"Минимальное число через Math.Min: { Math.Min(Math.Min(a,b),c)}");
            Console.ReadLine();

            //2.Написать метод подсчета количества цифр числа.
            Console.Write("Введите число для подсчета количества цифр в нем: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе {d} = {DigitsInNumber(d)}");

            //3.С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечётных
            //положительных чисел.



            //4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На
            //выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password:
            //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
            //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
            //цикла do while ограничить ввод пароля тремя попытками.
            //5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
            //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            //6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
            //000. «Хорошим» называется число, которое делится на сумму своих цифр​.Реализовать
            //подсчёт времени выполнения программы, используя структуру DateTime.
            //7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.ReadLine();

        }
    }
}
