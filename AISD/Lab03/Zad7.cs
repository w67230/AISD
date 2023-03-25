using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab03
{
    public class Zad7
    {
        private static int liczbaKrazkow = 4;


        private static string[,] tab = GenerujWiezeHanoi(liczbaKrazkow);
        private static int krok = 0;
        private static int wie = 0, kol = 0;

        public static string[,] GenerujWiezeHanoi(int wielkosc)
        {
            if(wielkosc > 10) wielkosc = 10;
            if(wielkosc < 1) wielkosc = 1;

            string[,] tab = new string[wielkosc, 3];
            for(int i = wielkosc - 1; i >= 0; i--)
            {
                for(int k = 0; k < 3; k++)
                {
                    if (k == 0) tab[i, k] = Convert.ToString(i);
                    else tab[i, k] = "|";
                }
            }

            return tab;

        }

        private static void Rysuj()
        {
            if(krok > 0) Console.WriteLine("Krok " + krok + ":");
            Console.WriteLine();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for( int k = 0; k < tab.GetLength(1); k++)
                {
                    Console.Write(tab[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            krok++;
        }

        private static void GetMinElementIndex()
        {
            bool koniec = false;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int k = 0; k < tab.GetLength(1); k++)
                {
                    if (tab[i,k] == "0")
                    {
                        wie = i;
                        kol = k;
                        koniec = true;
                        break;
                    }
                }
                if (koniec) break;
            }
        }

        private static void GetDrugiMinElementIndex()
        {
            int min = 11;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int k = 0; k < tab.GetLength(1); k++)
                {
                    if (tab[i, k] != "0" && tab[i, k] != "|")
                    {
                        if (tab[i-1, k] == "|" && Convert.ToInt32(tab[i,k]) < min)
                        {
                            min = Convert.ToInt32(tab[i, k]);
                            wie = i;
                            kol = k;
                        }
                    }
                }
            }
        }

        private static void Przenies()
        {
            if(krok%2 == 1)
            {
                GetMinElementIndex();
                tab[wie, kol] = "|";
                if(liczbaKrazkow%2 == 0)
                {
                    if (kol == 2) kol = 0;
                    else kol++;
                }
                else
                {
                    if (kol == 0) kol = 2;
                    else kol--;
                }
                wie = liczbaKrazkow - 1;
                while (tab[wie, kol] != "|")
                {
                    wie--;
                }
                tab[wie, kol] = "0";
            }
            else
            {
                GetDrugiMinElementIndex();
                string temp = tab[wie, kol];
                tab[wie, kol] = "|";
                if (kol == 2) kol = 0;
                else kol++;
                wie = liczbaKrazkow - 1;
                while (tab[wie, kol] != "|")
                {
                    if (tab[wie, kol] == "0")
                    {
                        if (kol == 2) kol = 0;
                        else kol++;
                        wie = liczbaKrazkow - 1;
                    }
                    else wie--;
                }
                tab[wie, kol] = temp;
            }
        }

        public static void Run()
        {
            Console.WriteLine("Zad7 - program ukladajacy wieze hanoi");
            Console.WriteLine();
            Console.WriteLine("Wcisnij enter aby przejsc do nastepnego kroku");

            Rysuj();

            while (tab[0,2] == "|")
            {
                Console.ReadLine();
                Przenies();
                Rysuj();
            }

            Console.WriteLine();
            Console.WriteLine("Wieza zostala ulozona");

        }
    }
}
