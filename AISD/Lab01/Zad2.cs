using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab01
{
    public class Zad2
    {
        private static int n = 0, ujemne;
        public static void Run()
        {
            Console.WriteLine("Zad2 - program wyznaczający ilość liczb ujemnych w podanym ciągu");
            Console.WriteLine();

            while(n <= 0)
            {
                Console.WriteLine("Podaj dlugosc ciagu (wyzsza niz zero)");
                n = Convert.ToInt32(Console.ReadLine());
            }

            ujemne = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                if(Convert.ToInt32(Console.ReadLine()) < 0)
                {
                    ujemne++;
                }
            }

            Console.WriteLine("Ilosc liczb ujemnych w ciagu: " + ujemne);
        }
    }
}
