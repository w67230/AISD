using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab01
{
    public class Zad5
    {
        public static int[,] GenerujLosowaTabliceDwuwymiarowa(int liczbaWierszy, int liczbaKolumn)
        {
            Random rand = new Random();
            int[,] tab = new int[liczbaWierszy, liczbaKolumn];
            for (int i = 0; i < liczbaWierszy; i++)
            {
                for(int j = 0; j < liczbaKolumn; j++)
                {
                    tab[i, j] = rand.Next(100);
                }
            }

            return tab;
        }

        public static void Run()
        {
            Console.WriteLine("Zad5 - wyszukiwanie minimalnej wartosci w kazdym wierszu tablicy dwuwymiarowej i przeniesienie jej na poczatek danego wiersza");
            Console.WriteLine();

            int[,] tab = GenerujLosowaTabliceDwuwymiarowa(3, 5);
            Console.WriteLine("Wartosci tablicy przed przeniesieniem elementu minimalnego na poczatek: ");
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for( int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }

            int min = 0, pierwszy = 0, elMin = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                min = 0;
                elMin = tab[i, 0];
                pierwszy = tab[i, 0];
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if(tab[i, j] < elMin)
                    {
                        min = j;
                        elMin=tab[i, j];
                    }
                        
                }
                if(min > 0)
                {
                    tab[i, 0] = tab[i, min];
                    tab[i, min] = pierwszy;
                }

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Wartosci tablicy po przeniesieniu elementu minimalnego na poczatek: ");
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
