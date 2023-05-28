using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab09
{
    public class Zad3
    {
        private static string input = "";
        private static bool skierowany;
        private static bool wazony;

        private static void WybierzTypGrafu()
        {
            Console.WriteLine("Wybierz jaki graf chcesz zbudowac:");
            Console.WriteLine("1 - graf skierowany");
            Console.WriteLine("2 - graf nieskierowany");
            input = Console.ReadLine();
            if(input != "1" && input != "2")
            {
                Console.Clear();
                WybierzTypGrafu();
                return;
            }
            if(input == "1") skierowany = true;
            else skierowany = false;
            Console.WriteLine("Czy chcesz aby graf byl wazony? Wpisz: tak , jezeli chcesz aby graf byl wazony.");
            input = Console.ReadLine();
            if (input == "tak") wazony = true;
            else wazony = false;
        }

        private static void PodajWierzcholki(Graph graf)
        {
            Console.WriteLine("Podaj ile wierzcholkow chcesz stworzyc w tym grafie");
            int i;
            input = Console.ReadLine();
            while (true)
            {
                try
                {
                    i = Convert.ToInt32(input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Nalezy podac liczbe!");
                    Console.WriteLine();
                    Console.WriteLine("Podaj ile wierzcholkow chcesz stworzyc w tym grafie");
                }
            }

            for(int l = 1; l <= i; l++)
            {
                Console.WriteLine("Podaj nazwe wierzcholka " + l + ":");
                input = Console.ReadLine();
                graf.AddVertex(new Vertex(input));
            }
        }

        private static void PodajPolaczenia(Graph graf)
        {
            Console.WriteLine("Podaj ile polaczen miedzy wierzcholkami chcesz stworzyc w tym grafie");
            int i;
            input = Console.ReadLine();
            while (true)
            {
                try
                {
                    i = Convert.ToInt32(input);
                    break;
                }
                catch
                {
                    Console.WriteLine("Nalezy podac liczbe!");
                    Console.WriteLine();
                    Console.WriteLine("Podaj ile polaczen miedzy wierzcholkami chcesz stworzyc w tym grafie");
                }
            }

            string drugiWierzcholek = "";
            for (int l = 1; l <= i; l++)
            {
                Console.WriteLine("Polaczenie nr: " + l);
                Console.WriteLine("Podaj nazwe wierzcholka, ktory bedzie sie laczyl z drugim wierzcholkiem");
                input = Console.ReadLine();
                Console.WriteLine("Podaj nazwe drugiego wierzcholka");
                drugiWierzcholek = Console.ReadLine();

                int waga = 0;
                if (wazony)
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Podaj wage tworzonego polaczenia");
                            waga = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Nalezy podac liczbe!");
                            Console.WriteLine();
                        }
                    }
                }

                graf.AddEdge(graf.GetVertexByNameOrCreateNew(input), graf.GetVertexByNameOrCreateNew(drugiWierzcholek), waga);
            }
        }

        private static void WyswietlMacierzSasiedztwa(Graph graf)
        {
            Console.WriteLine();
            int wielkosc = graf.GetVertices().Count;
            int[,] macierz = new int[wielkosc, wielkosc];
            for (int i = 0; i < wielkosc; i++)
            {
                for(int j = 0; j < wielkosc; j++)
                {
                    macierz[i, j] = 0;
                }
            }

            int firstVertex, secondVertex, weight;
            for(int i = 0; i < graf.GetEdges().Count; i++)
            {
                firstVertex = graf.GetVertices().IndexOf(graf.GetEdge(i).Item1);
                secondVertex = graf.GetVertices().IndexOf(graf.GetEdge(i).Item2);
                weight = graf.GetEdge(i).Item3 + Convert.ToInt32(!wazony);

                macierz[firstVertex, secondVertex] = weight;
            }


            Console.WriteLine("Macierz sasiedztwa utworzonego grafu:");
            Console.WriteLine();
            for(int i = 0; i < wielkosc; i++)
            {
                
                if(i == 0)
                {
                    Console.Write(" " + "\t");
                    for(int k = 0; k < wielkosc; k++)
                    {
                        Console.Write(graf.GetVertices()[k].GetNazwa() + "\t");
                    }
                }

                Console.WriteLine();
                for(int j = 0; j < wielkosc; j++)
                {
                    if (j == 0) Console.Write(graf.GetVertices()[i].GetNazwa() + "\t");
                    Console.Write(macierz[i, j] + "\t");
                }
            }
        }

        public static void WyswietlListeSasiedztwa(Graph graf)
        {
            Console.WriteLine(); 
            Console.WriteLine("Lista sasiedztwa utworzonego grafu:");
            for (int i = 0;i < graf.GetVertices().Count; i++)
            {
                Vertex ver = graf.GetVertices()[i];
                Console.Write(ver.GetNazwa() + ": ");
                foreach(KeyValuePair<Vertex, int> pair in ver.GetConnections())
                {
                    if(wazony) Console.Write("(" + pair.Key.GetNazwa() + "," + pair.Value + ")" + " -> ");
                    else Console.Write(pair.Key.GetNazwa() + " -> ");
                }
                Console.Write("null");
                Console.WriteLine();
            }
        }

        public static Graph StworzGraf()
        {
            WybierzTypGrafu();
            Graph graf = new Graph(!skierowany);
            PodajWierzcholki(graf);
            PodajPolaczenia(graf);
            return graf;
        }


        public static void Run()
        {
            Console.WriteLine("Zadanie 3 - program do budowania grafow");
            Console.WriteLine();

            Graph graf = StworzGraf();

            WyswietlMacierzSasiedztwa(graf);
            Console.WriteLine();
            WyswietlListeSasiedztwa(graf);

        }
    }
}
