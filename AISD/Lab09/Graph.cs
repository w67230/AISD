using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab09
{
    public class Graph
    {

        private List<Vertex> vertices;
        private List<(Vertex, Vertex, int)> edges;
        private int numVertices;
        private int numEdges;
        private bool dwuKierunkowy;

        public Graph(bool dwuKierunkowy = false)
        {
            this.vertices = new List<Vertex>();
            this.edges = new List<(Vertex, Vertex, int)>();
            this.numVertices = 0;
            this.numEdges = 0;
            this.dwuKierunkowy = dwuKierunkowy;
        }

        public List<Vertex> GetVertices()
        {
            return this.vertices;
        }

        public Vertex GetVertex(int index)
        {
            return this.vertices[index];
        }

        public Vertex GetVertexByNameOrCreateNew(string name)
        {
            List<Vertex> verts = this.GetVertices();
            for(int i = 0; i < verts.Count; i++)
            {
                if(verts[i].GetNazwa() == name)
                {
                    return verts[i];
                }
            }
            Vertex ver = new Vertex(name);
            this.AddVertex(ver);
            return ver;
        }

        public List<(Vertex, Vertex, int)> GetEdges()
        {
            return this.edges;
        }

        public (Vertex, Vertex, int) GetEdge(int index)
        {
            return this.edges[index];
        }

        public void AddEdgeToList((Vertex, Vertex, int) edge)
        {
            this.GetEdges().Add(edge);
            this.numEdges++;
        }

        public void AddVertex(Vertex vertex)
        {
            this.GetVertices().Add(vertex);
            this.numVertices++;
        }

        public void AddEdge(Vertex from, Vertex to, int cost = 0)
        {
            List<Vertex> list = this.GetVertices();
            if (!list.Contains(from))
            {
                this.AddVertex(from);
            }
            if (!list.Contains(to))
            {
                this.AddVertex(to);
            }

            from.AddNeighbor(to, cost);
            if (dwuKierunkowy) to.AddNeighbor(from, cost);

            this.AddEdgeToList((from, to, cost));
            if(dwuKierunkowy) this.AddEdgeToList((to, from, cost));


        }

        public void SortujListePolaczen()
        {
            (Vertex, Vertex, int) temp;
            for (int i = 1; i < this.edges.Count; i++)
            {
                if (this.edges[i].Item3 < this.edges[i - 1].Item3)
                {
                    temp = this.edges[i];
                    this.edges[i] = this.edges[i - 1];
                    this.edges[i - 1] = temp;
                    if (i > 1) i -= 2;
                }
            }
        }

    }
}
