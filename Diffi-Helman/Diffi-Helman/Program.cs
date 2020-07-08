using System;

namespace Diffi_Helman
{
    class Program
    {
        static void Main()
        {
            int a, b, g, p;
            Console.WriteLine("Введите числа a, b, g, p: ");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int.TryParse(Console.ReadLine(), out g);
            int.TryParse(Console.ReadLine(), out p);
            double A = Math.Pow(g, a) % p;
            Console.WriteLine("Значение A:" + A.ToString());
            double B = Math.Pow(g, b) % p;
            Console.WriteLine("Значение B:" + B.ToString());
            double Ka = Math.Pow(B, a) % p;
            Console.WriteLine("Значение ключа Ka:" + Ka.ToString());
            double Kb = Math.Pow(A, b) % p;
            Console.WriteLine("Значение ключа Kb:" + Kb.ToString());
            double K = Math.Pow(g, a * b) % p;
            Console.WriteLine("Искомый ключ K:"  +  K.ToString());
            Console.ReadKey();
        }
    }
}
