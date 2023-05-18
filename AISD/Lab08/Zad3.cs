using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab08
{
    public class Zad3
    {

        public static List<int> ScalObieListy(List<int> pierwszaLista, List<int> drugaLista)
        {
            List<int> result = new List<int>();
            result.AddRange(pierwszaLista);
            result.AddRange(drugaLista);
            return result;
        }


        public static void Run()
        {
            Console.WriteLine("Zadanie 3 - funkcja scalajaca dwie listy w jedna (funkcja zwraca nowa liste, poprzednie listy nie sa modyfikowane)");
            Console.WriteLine();

            List<int> list = new List<int> { 3, 1, 2, 7 };
            List<int> drugaList = new List<int> { 13, 11, 21, 71 };

            Console.WriteLine("Elementy listy 1: ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Elementy listy 2: ");
            for (int i = 0; i < drugaList.Count; i++)
            {
                Console.Write(drugaList[i] + " ");
            }
            Console.WriteLine();

            List<int> scalona = ScalObieListy(list, drugaList);

            Console.WriteLine("Elementy scalonej listy: ");
            for (int i=0; i< scalona.Count; i++)
            {
                Console.Write(scalona[i] + " ");
            }



        }
    }
}
