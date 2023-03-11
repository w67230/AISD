using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab01
{
    public class Zad3
    {

        public static int[] GenerujLosowaTabliceJednowymiarowa(int liczbaElementow)
        {
            Random rand = new Random();
            int[] tab = new int[liczbaElementow];
            for(int i = 0; i < liczbaElementow; i++)
            {
                tab[i] = rand.Next(100);
            }

            return tab;
        }
        public static void Run()
        {
            Console.WriteLine("Zad3 - program sprawdzający czy podana wartość znajduje się w tablicy jednowymiarowej");
            Console.WriteLine();

            int[] tab = GenerujLosowaTabliceJednowymiarowa(10);
            Console.WriteLine("Podaj szukana wartosc (od 0 do 99 wlacznie)");
            int n = Convert.ToInt32(Console.ReadLine());
            bool bl = false;
            for(int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == n)
                {
                    bl = true;
                    break;
                }
            }

            if (bl)
            {
                Console.WriteLine("Podana wartosc znajduje sie w tablicy");
            }
            else Console.WriteLine("Nie znaleziono w tablicy podanej wartosci");

            Console.WriteLine();
            Console.WriteLine("Wszystkie wartosci tablicy:");
            for(int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + " ");
            }
        }
    }
}
