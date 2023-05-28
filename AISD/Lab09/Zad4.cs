using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab09
{
    public class Zad4
    {

        public static void Run()
        {
            Console.WriteLine("Zadanie 4 - algorytm wyznaczania najkrotszej drogi");
            Console.WriteLine();

            Graph graf = Zad3.StworzGraf();
            Console.WriteLine();
            Console.WriteLine("Wyznaczanie najkrotszej drogi:");

            Vertex start, end;

            Console.WriteLine("Podaj nazwe wierzcholka startowego");
            start = graf.GetVertexByNameOrCreateNew(Console.ReadLine());
            Console.WriteLine("Podaj nazwe wierzcholka do ktorego ma zostac wyznaczona najkrotsza droga");
            end = graf.GetVertexByNameOrCreateNew(Console.ReadLine());

            Stack<int> stack = new Stack<int>();
            HashSet<Vertex> odwiedzone = new HashSet<Vertex>();
            List<Vertex> droga = new List<Vertex>();
            PriorityQueue<(Vertex, int), int> queue = new PriorityQueue<(Vertex, int), int>();

            odwiedzone.Add(start);
            stack.Push(0);

            (Vertex, int) tuple;
            while(start.GetNazwa() != end.GetNazwa())
            {
                if(start.GetConnections().Count < 1)
                {
                    stack.Pop();
                    start = droga[droga.Count - 1];
                }
                else
                {
                    droga.Add(start);
                }

                foreach(KeyValuePair<Vertex, int> pair in start.GetConnections())
                {
                    if(!odwiedzone.Contains(pair.Key)) queue.Enqueue((pair.Key, pair.Value), pair.Value);
                }
                if(queue.Count < 1)
                {
                    Console.WriteLine("Wyznaczony wierzcholek startowy nie posiada zadnej mozliwej drogi do wierzcholka koncowego!");
                    return;
                }
                tuple = queue.Dequeue();
                start = tuple.Item1;
                stack.Push(tuple.Item2);


                odwiedzone.Add(start);
                queue.Clear();
            }

            int koszt = 0;
            while(stack.Count > 0)
            {
                koszt += stack.Pop();
            }

            Console.WriteLine();
            Console.WriteLine("Najnizszy koszt dojscia do wyznaczonego wierzcholka koncowego to: " + koszt);
            Console.Write("Droga: ");
            for(int i = 0; i < droga.Count; i++)
            {
                Console.Write(droga[i].GetNazwa() + " -> ");
            }
            Console.Write(end.GetNazwa());

        }
    }
}
