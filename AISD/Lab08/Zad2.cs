using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab08
{
    public class Zad2
    {

        public static void UsunPodanaWartoscZListy(List<int> list, int usuwanyWezel)
        {
            if (list.Count < usuwanyWezel)
            {
                Console.WriteLine("Podany wezel nie istnieje ");
                return;
            }
            list.RemoveAt(usuwanyWezel-1);
            Console.WriteLine("Usunieto " + usuwanyWezel + " wezel");
        }


        public static void Run()
        {
            Console.WriteLine("Zadanie 2 - funkcja usuwajaca i-ty wezel z listy");
            Console.WriteLine();

            List<int> list = new List<int> { 3, 1, 2, 7 };

            Console.WriteLine("Elementy listy: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            UsunPodanaWartoscZListy(list, 1);
            UsunPodanaWartoscZListy(list, 2);
            UsunPodanaWartoscZListy(list, 2);
            UsunPodanaWartoscZListy(list, 4);

            Console.WriteLine("Elementy listy: ");
            for (int i=0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }


        }
    }
}
