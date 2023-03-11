using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab01
{
    public class Zad1
    {
        private static int a, b, c;
        private static double delta, x1, x2;

        public static void Run()
        {
            Console.WriteLine("Zad1 - program wyznaczający pierwiastki równania kwadratowego");
            Console.WriteLine();

            Console.WriteLine("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("x = " + x1);
                }
                else Console.WriteLine("Brak rozwiązań rzeczywistych");
            }
            else Console.WriteLine("To nie jest równanie kwadratowe");
        }
    }
}
