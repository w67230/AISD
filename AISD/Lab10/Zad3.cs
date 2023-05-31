using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISD.Lab09;

namespace AISD.Lab10
{
    public class Zad3
    {



        public static void Run()
        {
            Console.WriteLine("Zadanie 3 - program do przeszukiwania grafow metoda BFS");
            Console.WriteLine();

            Graph graf = Lab09.Zad3.StworzGraf();
            HashSet<Vertex> odwiedzone = new HashSet<Vertex>();
            Dictionary<Vertex, int> koszt = new Dictionary<Vertex, int>();
            Dictionary<Vertex, Vertex> poprzednik = new Dictionary<Vertex, Vertex>();

            for (int i = 0; i < graf.GetVertices().Count; i++)
            {
                koszt.Add(graf.GetVertex(i), -1);
                poprzednik.Add(graf.GetVertex(i), null);
            }

            Console.WriteLine("Podaj nazwe wierzcholka startowego");
            Vertex pierwszy = graf.GetVertexByNameOrCreateNew(Console.ReadLine());
            odwiedzone.Add(pierwszy);
            koszt[pierwszy] = 0;
            Queue<Vertex> queue = new Queue<Vertex>();
            queue.Enqueue(pierwszy);
            Vertex u;
            while (queue.Count != 0)
            {
                u = queue.Dequeue();
                foreach (KeyValuePair<Vertex, int> pair in u.GetConnections())
                {
                    if (!odwiedzone.Contains(pair.Key))
                    {
                        odwiedzone.Add(pair.Key);
                        koszt[pair.Key] = koszt[u] + 1;
                        poprzednik[pair.Key] = u;
                        queue.Enqueue(pair.Key);
                    }
                }

            }

            Console.WriteLine("Wierzcholki oraz koszt dojscia do nich:");
            foreach (KeyValuePair<Vertex, int> pair in koszt)
            {
                Console.WriteLine(pair.Key.GetNazwa() + " : " + pair.Value);
            }

        }
    }
}
