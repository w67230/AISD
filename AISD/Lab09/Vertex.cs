using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Lab09
{
    public class Vertex
    {

        private string nazwa;

        private Dictionary<Vertex, int> connections;

        public Vertex(string nazwa)
        {
            this.nazwa = nazwa;
            this.connections = new Dictionary<Vertex, int>();
        }

        public string GetNazwa()
        {
            return nazwa;
        }

        public Dictionary<Vertex, int> GetConnections()
        {
            return this.connections;
        }

        public void AddNeighbor(Vertex vertex, int cost)
        {
            if(!connections.ContainsKey(vertex)) this.connections.Add(vertex, cost);
            else if (connections[vertex] > cost) connections[vertex] = cost;
        }
    }
}
