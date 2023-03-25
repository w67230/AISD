using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab03
{
    public class Zad1
    {
        public static long Silnia(long n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Silnia(n - 1);
        }

        public static void Run()
        {
            Console.WriteLine("Zad 1 - rekurencyjny program obliczania silni dla liczby dodatniej calkowitej");
            Console.WriteLine();
            Console.WriteLine("Podaj liczbe dodatnia");
            int i = -1;
            while (i <= 0)
            {
                i = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(i + "! = " + Silnia(i));
        }
    }
}
