using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab06
{
    public class Zad2
    {
        public static void Run()
        {
            Console.WriteLine("Zad2 - sprawdzanie ilosci liczb parzystych w podanej przez uzytkownika 10 - elementowej tablicy typu int");
            Console.WriteLine();

            int[] tab = new int[10];
            int p = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Podaj liczbe");
                tab[i] = Convert.ToInt32(Console.ReadLine());
                if (tab[i] % 2 == 0) p++;
            }

            if (p > 0) Console.WriteLine("Liczba parzystych liczb w tablicy: " + p);
            else Console.WriteLine("W tablicy nie ma liczb parzystych");
        }
    }
}
