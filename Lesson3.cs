using System;
namespace Lesson3
{
    internal class Lesson3
    {
        private static void Pause() => Console.ReadLine();
        static void ChangeSign(ref int a, ref int b, ref int c)
        {
            a = -a;
            b = -b;
            c = -c;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            Console.WriteLine($"{a}{b}{c}");
            ChangeSign(ref a, ref b, ref c);
            Console.WriteLine($"{a}{b}{c}");

            Pause();

        }
    }
}
