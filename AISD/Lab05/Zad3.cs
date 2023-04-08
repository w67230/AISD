using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab05
{
    public class Zad3
    {

        public static int ObliczNtyWyrazCiagu(int n)
        {
            if (n < 2) return 1;
            int[] tab = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                if (i < 2) tab[i] = 1;
                else
                {
                    tab[i] = 2 * tab[i - 1] - tab[i - 2];
                }
            }
            return tab[n];
        }

        public static void Run()
        {
            Console.WriteLine("Zad3 - program wyznaczajacy n-ty wyraz ciagu (bez sensu to zadanie bo podany jest ciag samych jedynek)");
            Console.WriteLine();

            int n = -1;
            Console.WriteLine("Podaj nr elementu do wyliczenia (wiekszy lub rowny 0)");
            while (n < 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
            }

            //pierwsze dwa wyrazy sa rowne 1 wiec program caly czas robi 2*1 - 1 co daje 1, czyli mamy ciag samych jedynek
            Console.WriteLine(ObliczNtyWyrazCiagu(n));

        }
    }
}
