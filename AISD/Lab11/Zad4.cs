using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AISD.Lab09;

namespace AISD.Lab11
{
    public class Zad4
    {

        private static bool LaczySieZPodanymWierzcholkiem(Vertex szukany, Dictionary<Vertex, int> connections, HashSet<Vertex> visited)
        {
            if(connections.Count > 0)
            {
                if (connections.ContainsKey(szukany)) return true;
                foreach(KeyValuePair<Vertex, int> pair in connections)
                {
                    if (!visited.Contains(pair.Key))
                    {
                        visited.Add(pair.Key);
                        if(LaczySieZPodanymWierzcholkiem(szukany, pair.Key.GetConnections(), visited)) return true;
                    }
                    
                }
            }
            return false;
        }

        private static void Kruskal(Graph graf)
        {
            for(int i = 0; i < graf.GetVertices().Count; i++)
            {
                graf.GetVertex(i).GetConnections().Clear();
            }
            graf.SortujListePolaczen();
            List<(Vertex, Vertex, int)> edges = new List<(Vertex, Vertex, int)> (graf.GetEdges());
            graf.GetEdges().Clear();

            for(int i = 0; i < edges.Count; i++)
            {
                if (!LaczySieZPodanymWierzcholkiem(edges[i].Item1, edges[i].Item2.GetConnections(), new HashSet<Vertex>() { edges[i].Item2 }))
                {
                    graf.AddEdge(edges[i].Item1, edges[i].Item2, edges[i].Item3);
                }
            }

            Lab09.Zad3.WyswietlMacierzSasiedztwa(graf);
            Lab09.Zad3.WyswietlListeSasiedztwa(graf);



        }

        private static Graph Prim(Graph graf)
        {
            PriorityQueue<(Vertex, Vertex, int), int> queue = new PriorityQueue<(Vertex, Vertex, int), int>();
            HashSet<Vertex> visited = new HashSet<Vertex>();
            Graph prim = new Graph(true);
            Vertex u = graf.GetVertex(0);
            visited.Add(u);
            (Vertex, Vertex, int) edge;
            for(int i = 0; i < graf.GetVertices().Count-1; i++)
            {
                foreach(KeyValuePair<Vertex, int> pair in u.GetConnections())
                {
                    if (!visited.Contains(pair.Key)) queue.Enqueue((u, pair.Key, pair.Value), pair.Value);
                }

                do
                {
                    edge = queue.Dequeue();
                } while (visited.Contains(edge.Item2));

                prim.AddEdge(prim.GetVertexByNameOrCreateNew(edge.Item1.GetNazwa()), prim.GetVertexByNameOrCreateNew(edge.Item2.GetNazwa()), edge.Item3);
                u = edge.Item2;
                visited.Add(u);
            }



            Lab09.Zad3.WyswietlMacierzSasiedztwa(prim);
            Lab09.Zad3.WyswietlListeSasiedztwa(prim);

            return prim;
        }

        public static void Run()
        {
            Console.WriteLine("Zadanie 4 algorytm Kruskala i Prima");
            Console.WriteLine();

            Graph graf = Lab09.Zad3.StworzGraf();
            Console.WriteLine();
            Console.WriteLine("Primowski graf:");
            Console.WriteLine();
            Graph primowski = Prim(graf);
            Console.WriteLine();
            Console.WriteLine("Kruskalowski graf:");
            Console.WriteLine();
            Kruskal(graf);
            

        }
    }
}
