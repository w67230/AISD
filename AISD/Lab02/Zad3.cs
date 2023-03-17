using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab02
{
    public class Zad3
    {
        private static int GetSmallerLength(string a, string b)
        {
            if(a.Length > b.Length) return b.Length;
            return a.Length;
        }

        public static void Run()
        {
            Console.WriteLine("Zad3 - program sortujacy liczby naturalne leksykograficznie wzgledem rozwiniec dziesietnych");
            Console.WriteLine();

            int[] liczby = Lab01.Zad3.GenerujLosowaTabliceJednowymiarowa(10);
            string[] a = new string[liczby.Length];
            Console.WriteLine("Wejscie: ");
            int indMax = 0;
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToString(liczby[i]);
                if (a[i].Length > a[indMax].Length)
                {
                    indMax = a[i].Length;
                }
                Console.Write(a[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Wyjscie:");
            int element;
            for(int i = 1; i < a.Length; i++)
            {
                element = Convert.ToInt32(a[i][0]);
                string el = a[i];
                for(int j = i-1; j >=0; j--)
                {
                    if(Convert.ToInt32(a[j][0]) < element)
                    {
                        break;
                    }
                    else if(Convert.ToInt32(a[j][0]) == element)
                    {
                        int l = 1, dlugosc = GetSmallerLength(a[j], el);
                        while (l < dlugosc)
                        {
                            if (Convert.ToInt32(a[j][l]) == Convert.ToInt32(el[l])) l++;
                            else break;
                        }

                        if (l == dlugosc) l--;
                        if(Convert.ToInt32(a[j][l]) < Convert.ToInt32(el[l]))
                        {
                            break;
                        }
                        else if(Convert.ToInt32(a[j][l]) == Convert.ToInt32(el[l]))
                        {
                            if (a[j].Length < el.Length) break;
                        }
                        
                    }
                    a[j + 1] = a[j];
                    a[j] = el;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                liczby[i] = Convert.ToInt32(a[i]);
                Console.Write(liczby[i] + " ");
            }

        }
    }
}
