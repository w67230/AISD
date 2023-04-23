using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab06
{
    public class Zad1
    {
        public static void Run()
        {
            Console.WriteLine("Zad1 - obliczanie ilosci liczb ujemnych w podanym ciagu");
            Console.WriteLine();

            Console.WriteLine("Podaj dlugosc ciagu");
            int n = 0;
            while (n < 1)
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            int liczba, ujemne = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba % 2 == 0) ujemne++;
            }

            Console.WriteLine("Ilosc liczb ujemnych w podany ciagu: " + ujemne);
        }
    }
}
