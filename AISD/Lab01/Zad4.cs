using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab01
{
    public class Zad4
    {
        public static void Run()
        {
            Console.WriteLine("Zad4 - wyszukiwanie wartości minimalnej w tablicy jednowymiarowej");
            Console.WriteLine();

            int[] tab = Zad3.GenerujLosowaTabliceJednowymiarowa(10);

            Console.WriteLine("Wartosci tablicy: ");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }

            Console.WriteLine();

            int min = tab[0];
            for(int i = 1; i < tab.Length; i++)
            {
                if(tab[i] < min) min = tab[i];
            }

            Console.WriteLine("Element minimalny powyzszej tablicy: " + min);
        }
    }
}
