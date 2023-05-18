using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab08
{
    public class Zad5
    {

        public static bool SzukajBinarnie(List<int> list, int szukanaWartosc)
        {
            Zad4.SortujListe(list); // <------ lista musi byc posortowana zeby dzialalo
            int start = 0, end = list.Count - 1, mid = end/ 2;
            List<int> pierPolowka = new List<int>();
            while (true)
            {
                pierPolowka.Clear();
                pierPolowka.AddRange(list.GetRange(start, (mid-start)+1));


                if (szukanaWartosc == pierPolowka[pierPolowka.Count - 1])
                {
                    return true;
                }
                else if(szukanaWartosc < pierPolowka[pierPolowka.Count-1])
                {
                    end = mid;
                    mid = (end + start) / 2;
                }
                else
                {
                    start = mid+1;
                    mid = (end + start) / 2;
                }

                if (start == end)
                {
                    if (szukanaWartosc != pierPolowka[pierPolowka.Count - 1]) return false;
                    return true;
                }
            }
            return false;
        }

        public static void Run()
        {
            Console.WriteLine("Zadanie 5 - wyszukiwanie binarne");
            Console.WriteLine();

            List<int> list = new List<int> { 13, 1, 25, 79, 92, 16, 9, 63, 92, 1 };

            Console.WriteLine("Podaj liczbe do znaleienia w liscie");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Liczba " + x + " w liscie: " + SzukajBinarnie(list, x));

            Console.WriteLine();
            Console.WriteLine("Elementy listy: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
