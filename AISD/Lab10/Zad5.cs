using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISD.Lab09;

namespace AISD.Lab10
{
    public class Zad5
    {
        private static int time;
        private static HashSet<Vertex> odwiedzone = new HashSet<Vertex>();
        private static Dictionary<Vertex, int> time_1 = new Dictionary<Vertex, int>();
        private static Dictionary<Vertex, int> time_2 = new Dictionary<Vertex, int>();
        private static Dictionary<Vertex, string> poprzednik = new Dictionary<Vertex, string>();

        private static void DFSik(Vertex vert)
        {
            time++;
            time_1.Add(vert, time);
            odwiedzone.Add(vert);
            foreach(Vertex v in vert.GetConnections().Keys)
            {
                if (!odwiedzone.Contains(v))
                {
                    poprzednik[v] = vert.GetNazwa();
                    DFSik(v);
                }
            }

            time++;
            time_2.Add(vert, time);
        }

        public static void Run()
        {
            Console.WriteLine("Zadanie 5 - przeszukiwanie grafu metoda DFS");
            Console.WriteLine();



            time = 0;
            Graph graf = Lab09.Zad3.StworzGraf();

            for(int i = 0; i < graf.GetVertices().Count; i++)
            {
                poprzednik.Add(graf.GetVertex(i), "-1");
            }

            for(int i = 0; i < graf.GetVertices().Count; i++)
            {
                if (!odwiedzone.Contains(graf.GetVertex(i))) DFSik(graf.GetVertex(i));
            }

            for(int i = 0; i < graf.GetVertices().Count; i++)
            {
                if (i == 0) Console.Write("\t");
                Console.Write(graf.GetVertex(i).GetNazwa() + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < graf.GetVertices().Count; i++)
            {
                if (i == 0) Console.Write("Poprz:\t");
                Console.Write(poprzednik[graf.GetVertex(i)] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < graf.GetVertices().Count; i++)
            {
                if (i == 0) Console.Write("Czas 1:\t");
                Console.Write(time_1[graf.GetVertex(i)] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < graf.GetVertices().Count; i++)
            {
                if (i == 0) Console.Write("Czas 2:\t");
                Console.Write(time_2[graf.GetVertex(i)] + "\t");
            }

        }
    }
}
