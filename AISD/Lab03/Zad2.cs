using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab03
{
    public class Zad2
    {

        public static int[] OdwrocTabliceInt(int[] tab, int i = 1, bool first = true)
        {
            do
            {
                if (i < tab.Length)
                {
                    tab = OdwrocTabliceInt(tab, i + 1, false);
                    if (i > 0)
                    {
                        int temp = tab[i - 1];
                        tab[i - 1] = tab[i];
                        tab[i] = temp;
                    }
                }
                i++;
            }while(first && i < tab.Length);


            return tab;
        }

        public static void Run()
        {
            Console.WriteLine("Zad 2 - rekurencyjny program do odwracanie elementów tablicy");
            Console.WriteLine();
            int[] tab = AISD.Lab01.Zad3.GenerujLosowaTabliceJednowymiarowa(9);
            Console.WriteLine("Wejscie:");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();

            OdwrocTabliceInt(tab);

            Console.WriteLine("Wyjscie:");
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
