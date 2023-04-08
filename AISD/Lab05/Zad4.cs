using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab05
{
    public class Zad4
    {
        public static long LiczDwumian(int n, int k)
        {
            long[] tab = new long[n + 1];

            for(int i = 0; i < tab.Length; i++)
            {
                if(i < 2) tab[i] = 1;
                else tab[i] = tab[i - 1] * i;
            }

            return tab[n] / (tab[k] * tab[n - k]);
        }


        public static void Run()
        {
            Console.WriteLine("Zad4 - obliczanie wspolczynnika dwumianowego");
            Console.WriteLine();

            int n = 0;
            Console.WriteLine("Podaj liczbe naturalna n (wieksza od zera)");
            while (n < 1)
            {
                n = Convert.ToInt32(Console.ReadLine());
            }

            int k = n + 1;
            Console.WriteLine("Podaj liczbe naturalna k (wieksza od zera, mniejsza badz rowna n)");
            while (k > n || k < 1)
            {
                k = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine(LiczDwumian(n, k));
        }
    }
}
