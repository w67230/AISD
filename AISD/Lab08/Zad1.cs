using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab08
{
    public class Zad1
    {

        public static bool ZnajdzWartoscWLiscie(List<int> list, int szukanaWartosc)
        {
            if (list.Contains(szukanaWartosc))
            {
                Console.WriteLine("Znaleziono podana wartosc na indeksie: " + list.IndexOf(szukanaWartosc));
                return true;
            }
            Console.WriteLine("Nie znaleziono w liscie podanej wartosci");
            return false;
        }


        public static void Run()
        {
            Console.WriteLine("Zadanie 1 - funkcja wyszukujaca w liscie podana wartosc");
            Console.WriteLine();

            List<int> list = new List<int> { 3, 1, 2 };

            ZnajdzWartoscWLiscie(list, 1);
            ZnajdzWartoscWLiscie(list, 2);
            ZnajdzWartoscWLiscie(list, 3);
            ZnajdzWartoscWLiscie(list, 4);


        }
    }
}
