using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab04
{
    public class Zad4
    {

        public static int SumaElementowDzielZwyciezaj(int[] tab, int ostatniEl, int pierwszyEl = 0, int suma = 0)
        {
            if (pierwszyEl == ostatniEl)
            {
                return suma + tab[pierwszyEl];
            }
            else if (pierwszyEl > ostatniEl) return suma;

            suma += tab[pierwszyEl] + tab[ostatniEl];

            return SumaElementowDzielZwyciezaj(tab, ostatniEl - 1, pierwszyEl + 1, suma);
        }

        public static void Run()
        {
            Console.WriteLine("Zad4 - liczenie sumy elementow tablicy metoda dziel i zwyciezaj");
            Console.WriteLine();

            int[] tab = Lab01.Zad3.GenerujLosowaTabliceJednowymiarowa(5);

            Console.WriteLine("Wejscie:");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Suma: " + SumaElementowDzielZwyciezaj(tab, tab.Length - 1));
        }
    }
}
