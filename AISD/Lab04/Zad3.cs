using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab04
{
    public class Zad3
    {

        public static int MaxElementDzielZwyciezaj(int[] tab, int ostatniEl, int pierwszyEl = 0, int maksymal = 0)
        {
            if(pierwszyEl >= ostatniEl)
            {
                if (tab[ostatniEl] > maksymal) return tab[ostatniEl];
                return maksymal;
            }
                
            int max = Math.Max(tab[pierwszyEl], tab[ostatniEl]);
            int max2 = MaxElementDzielZwyciezaj(tab, ostatniEl - 1, pierwszyEl + 1, max);
            if (max > max2) return max;
            return max2;
        }

        public static void Run()
        {
            Console.WriteLine("Zad3 - wyznaczanie najwiekszego elementu w tablicy metoda dziel i zwyciezaj");
            Console.WriteLine();

            int[] tab = Lab01.Zad3.GenerujLosowaTabliceJednowymiarowa(8);

            Console.WriteLine("Wejscie:");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Element maksymalny: " + MaxElementDzielZwyciezaj(tab, tab.Length - 1));
        }
    }
}
