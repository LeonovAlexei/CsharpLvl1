//                    Леонов Алексей
using System;

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
        /// <summary>
        /// Метод проверки пароля на входе логин и пароль на выходе true или false
        /// </summary>
        /// <param name="UserLogin"></param>
        /// <param name="UserPassword"></param>
        /// <returns></returns>
        public static bool Verification(string UserLogin, string UserPassword)
        {
            string login = "root";
            string password = "GeekBrains";
            if (UserLogin == login && UserPassword == password)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Метод нерекрусивный принимающий число int и выдающий сумму цифр этого числа
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Sum (int a)
        {
            int s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            return s;
        }
        /// <summary>
        /// Рекрусивный метод принимающий два числа и выводящий 
        /// последовательность этих цифр от a до b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void RecrusiveConslusion(int a, int b)
        {
            if (a <= b)
            {
            Console.Write($"{a}   ");
            RecrusiveConslusion(a+1, b);
                
            }
        }
        /// <summary>
        /// Рекрусивный метод принимающий два числа и выводящий 
        /// сумму последовательности этих цифр от a до b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static private int RecrusiveSumm(int a, int b)
        {
            int s = a;
            return a<b? s+RecrusiveSumm(a+1,b):s;
            
        }

        static void Main(string[] args)
           
        {
            #region
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
            Console.Write($"Минимальное число через Math.Min: { Math.Min(Math.Min(a, b), c)}");
            Console.ReadLine();

            //2.Написать метод подсчета количества цифр числа.
            Console.Write("Введите число для подсчета количества цифр в нем: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Количество цифр в числе {d} = {DigitsInNumber(d)}");

            //3.С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечётных
            //положительных чисел.
            double e;
            double sum = 0;
            Console.WriteLine("Вводите числа с клавиатуры \nдля подсчета суммы всех нечетных и положительных чисел \nДля окончания ввода введите \"0\"");
            do
            {
                e = Convert.ToDouble(Console.ReadLine());
                if (e > 0 && e % 2 != 0) sum = +e;
            }
            while (e != 0);
            Console.WriteLine($"Сумаа всех введенных нечетных и положительных чисел будет равна {sum}");

            //4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На
            //выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password:
            //GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
            //вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
            //цикла do while ограничить ввод пароля тремя попытками.
            int n = 0;
            bool v;
            do
            {
                Console.Write("Введите логин:");
                string UserLogin = Console.ReadLine();
                Console.Write("Введите пароль:");
                string UserPassword = Console.ReadLine();
                v = Verification(UserLogin, UserPassword);
                if (v == true)
                {
                    Console.WriteLine("Вы прошли проверку!");
                    break;
                }
                n++;
            } while (n < 3);
            if (v == false)
            {
                Console.WriteLine("Вы не прошли проверку!\nЗакрываем программу");
            }
            else
            {
                Console.WriteLine("Продолжаем программу...");
            }

            //5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
            //массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            //16 и менее  Выраженный дефицит массы тела
            //16—18,5 Недостаточная(дефицит) масса тела
            //18,5—24,99  Норма
            //25—30   Избыточная масса тела(предожирение)
            //30—35   Ожирение
            //35—40   Ожирение резкое
            //40 и более  Очень резкое ожирение
            double m, h, imt, nmin, nmax, minnormim, maxnormim;
            minnormim = 18.5;
            maxnormim = 24.99;
            Console.Write("Введите вес: ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост: ");
            h = Convert.ToDouble(Console.ReadLine()) / 100;
            imt = m / (h * h);
            nmin = minnormim * h * h;
            nmax = maxnormim * h * h;
            int indeximt = 0;
            if (imt <= 16)
            {
                indeximt = 1;
            }
            else if (imt > 16 && imt <= 18.5)
            {
                indeximt = 2;
            }
            else if (imt > 18.5 && imt <= 24.99)
            {
                indeximt = 3;
            }
            else if (imt >= 25 && imt <= 30)
            {
                indeximt = 4;
            }
            else if (imt > 30 && imt <= 35)
            {
                indeximt = 5;
            }
            else if (imt > 35 && imt <= 40)
            {
                indeximt = 6;
            }
            else if (imt > 40)
            {
                indeximt = 7;
            }
            if (m < 0 || h < 0)
            {
                indeximt = 0;
            }

            switch (indeximt)
            {
                case 1:
                    Console.WriteLine($"Выраженный дефицит массы тела\nВам нужно набрать от {nmin - m:n1} до {nmax - m:n1} кг. ");
                    break;
                case 2:
                    Console.WriteLine($"Недостаточная (дефицит) масса тела\nВам нужно набрать от {nmin - m:n1} до {nmax - m:n1} кг. ");
                    break;
                case 3:
                    Console.WriteLine("Норма");
                    break;
                case 4:
                    Console.WriteLine($"Избыточная масса тела(предожирение)\nВам нужно похудеть минимум на {m - nmax:n1} кг., а максимум на {m - nmin:n1} кг. ");
                    break;
                case 5:
                    Console.WriteLine($"Ожирение\nВам нужно похудеть минимум на {m - nmax:n1} кг., а максимум на {m - nmin:n1} кг. ");
                    break;
                case 6:
                    Console.WriteLine($"Ожирение резкое\nВам нужно похудеть минимум на {m - nmax:n1} кг., а максимум на {m - nmin:n1} кг. ");
                    break;
                case 7:
                    Console.WriteLine($"Очень резкое ожирение\nВам нужно похудеть минимум на {m - nmax:n1} кг., а максимум на {m - nmin:n1} кг. ");
                    break;
                default:
                    Console.WriteLine("Вес или рост введены не верно.\nВведите данные верно");
                    break;
            }

            #endregion
            #region
            //6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
            //000. «Хорошим» называется число, которое делится на сумму своих цифр​.Реализовать
            //подсчёт времени выполнения программы, используя структуру DateTime.
            DateTime start = DateTime.Now;
            int scope = 0;
            for (int k = 1; k < 1000000000; k++)
            {
                if (k % Sum(k) == 0)
                {
                    scope++;
                }
            }
            Console.WriteLine(scope);
            DateTime finish = DateTime.Now;
            Console.WriteLine(finish - start);
            #endregion
            //7.a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            // Переименовал переменные а и b чтобы не комментировать код.
            int y = 1;
            int z = 10;

            RecrusiveConslusion (y, z);
           
            Console.WriteLine(RecrusiveSumm(y, z));

            Console.ReadLine();

        }
    }
}
