using System;
using static CsharpLvl1.NeededMethods;


namespace CsharpLvl1
{
    partial class Program
    {



        static double Calculation(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Print(string msg, int x, int y, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            #region Задание 1 и Задание 2 (Начало)
            //Леонов Алексей
            //1.Написать программу «Анкета». Последовательно задаются вопросы
            //    (имя, фамилия, возраст, рост, вес).В результате вся информация
            //    выводится в одну строчку.
            //    а) используя склеивание;
            //    б) используя форматированный вывод;
            //    в) *используя вывод со знаком $.

            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) 
            //    по формуле I = m / (h * h); где m — масса тела в килограммах, 
            //    h — рост в метрах

            string name;
            string surname;
            double age;
            double growth;
            double weight;
            Console.Write("Введите имя : ");
            name = Console.ReadLine();
            Console.Write("Введите Фамилию : ");
            surname = Console.ReadLine();
            Console.Write("Введите возраст : ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост : ");
            growth = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + growth + " Вес: " + weight);
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2:G} Рост: {3:G} Вес: {4:N2}", name, surname, age, growth, weight);
            Console.WriteLine($"Имя: {name} Фамилия: {surname} Возраст: {age:G} Рост: {growth:G} Вес: {weight:N2}");
            Console.WriteLine($"Индекс массы тела при росте {growth / 100} м. и весе {weight} кг. равен {weight / (growth / 100 * growth / 100):N4}");
            #endregion Задание 1 и Задание 2 (Конец)
            #region Задание 3 (Начало)
            ////а) Написать программу, которая подсчитывает расстояние между точками с 
            ////    координатами x1, y1 и x2,y2 по формуле 
            ////    r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            ////    Вывести результат, используя спецификатор формата .2f
            ////    (с двумя знаками после запятой);
            ////б) *Выполните предыдущее задание, оформив вычисления расстояния между точками 
            ////    в виде метода;
            //double x1;
            //double y1;
            //double x2;
            //double y2;
            //Console.Write("Программа подсчета расстояния между точками \nВведите Координату X первой точки:");
            //x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите Координату Y первой точки:");
            //y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите Координату X втрой точки:");
            //x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите Координату Y втрой точки:");
            //y2 = Convert.ToDouble(Console.ReadLine());
            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Console.WriteLine($"Расстояние между точками = {r:f2}");
            //задание 3 Б
            // Console.WriteLine($"Расстояние между точками = {Calculation(x1, y1, x2, y2):f2}");
            #endregion Задание 3 (Конец)
            #region Задание 4
            ////4.Написать программу обмена значениями двух переменных.
            ////    а) с использованием третьей переменной;
            ////    б) *без использования третьей переменной.
            //double a = 10;
            //double b = 20;
            //double t;
            //Console.WriteLine($"Задаем значения переменным а = {a} b = {b} меняем значение через переменную t");
            //t = a;
            //a = b;
            //b = t;
            //Pause();
            //Console.WriteLine($"Выводим измененные значения переменных: а ={a} ,b ={b} ");
            //Console.WriteLine($"Меняем значения переменных без использования дополнительной переменной a ={a}, b={b}");
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine($"Выводим измененные значения переменных: а ={a} ,b ={b} ");
            #endregion
            #region Задание 5
            //    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //    //б) Сделать задание, только вывод организуйте в центре экрана
            //    //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            //name = "Алексей";
            //surname = "Леонов";
            //string sity = "Краснодар";
            //string msg = ($"Имя:{name} Фамилия:{surname} Город проживания: {sity}");
            //Console.WriteLine(msg);
            //Console.SetCursorPosition(35, 15);
            //Console.WriteLine(msg);
            ////Задание 5 в
            //int x;
            //int y;
            //Console.Write("Для использования метода \"Print\" Введите позицию столбца курсора x:");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("                                  Введите позицию строки курсора y:");
            //y = Convert.ToInt32(Console.ReadLine());
            //Print(msg, x, y);
            //ConsoleColor color = ConsoleColor.Green;
            //Print(msg,x,y+1,color);
            #endregion
            ////6. * Создать класс с методами, которые могут пригодиться в вашей учебе
            ////(Print, Pause).
            Pause();//Pause прописан в классе NeededMethods
        }
    }
}
