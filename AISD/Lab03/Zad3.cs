using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab03
{
    public class Zad3
    {
        public static int NWDIter(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }

        public static int NWDRek(int a, int b)
        {
            if (a != b)
            {
                if (a > b) return NWDRek(a - b, b);
                else return NWDRek(a, b - a);
            }
            return a;
        }

        public static int NWDIterII(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = a % b;
            }
            return a;
        }

        public static int NWDRekII(int a, int b)
        {
            if (b != 0)
            {
                return NWDRekII(b, a % b);
            }
            return a;
        }

        public static void Run()
        {
            int a, b;
            Console.WriteLine("Podaj a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NWD iteracyjnie: " + NWDIter(a, b));
            Console.WriteLine("NWD rekurencyjnie: " + NWDRek(a, b));
            Console.WriteLine("NWD iteracyjnie (2 wersja): " + NWDIterII(a, b));
            Console.WriteLine("NWD rekurencyjnie (2 wersja): " + NWDRekII(a, b));
        }
    }
}
