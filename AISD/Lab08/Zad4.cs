using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab08
{
    public class Zad4
    {

        public static void SortujListe(List<int> list)
        {
            int temp;
            for(int i = 1; i < list.Count; i++)
            {
                if(list[i] < list[i - 1])
                {
                    temp = list[i];
                    list[i] = list[i - 1];
                    list[i - 1] = temp;
                    if (i > 1) i -= 2;
                }
            }
        }

        public static void DodajPosortowanaLiczbeDoListy(List<int> list, int dodanaLiczba)
        {
            //list.Sort();
            SortujListe(list);
            for(int i = 0; true; i++)
            {
                if(i == list.Count)
                {
                    list.Add(dodanaLiczba);
                    break;
                }
                if (list[i] < dodanaLiczba) continue;
                list.Insert(i, dodanaLiczba);
                break;
            }
        }


        public static void Run()
        {
            Console.WriteLine("Zadanie 4 - funkcja dodajaca nowe liczby do listy tak, ze lista jest ciagle posortowana");
            Console.WriteLine();

            List<int> list = new List<int> { 13, 1, 25, 79, 92, 16, 9, 63, 92, 1 };

            Console.WriteLine("Elementy listy: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            DodajPosortowanaLiczbeDoListy(list, 2);
            DodajPosortowanaLiczbeDoListy(list, 93);
            DodajPosortowanaLiczbeDoListy(list, 38);



            Console.WriteLine("Elementy listy po dodaniu : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();






        }
    }
}
