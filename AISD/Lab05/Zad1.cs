using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab05
{
    public class Zad1
    {

        public static int[] Fib(int n)
        {
            int[] tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i < 2) tab[i] = i;
                else tab[i] = tab[i - 1] + tab[i - 2];
            }
            return tab;
        }

        public static void Run()
        {
            Console.WriteLine("Zad1 - obliczanie elementow ciagu Fibonacciego");
            Console.WriteLine();

            int n = 0;
            Console.WriteLine("Podaj liczbe elementow do obliczenia (wieksza niz 0)");
            while(n <= 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
            }

            int[] tab = Fib(n);

            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
        }
    }
}
