using System.Text;

namespace grafy1
{
    internal class Graf1
    {
        private List<NodeG1> nodes;
        private List<Edge> edges;

        public Graf1()
        {
            nodes = new List<NodeG1>();
            edges = new List<Edge>();
        }


        public Graf1(Edge k) : this()
        {
            Add(k);
        }

        // Dodawanie krawedzi 
        public void Add(Edge k)
        {
            edges.Add(k);


            if (!nodes.Contains(k.start))
                nodes.Add(k.start);
            if (!nodes.Contains(k.end))
                nodes.Add(k.end);
        }


        public int ileNowychWezlow(Edge k)
        {
            int count = 0;

            if (!nodes.Contains(k.start))
                count++;
            if (!nodes.Contains(k.end))
                count++;

            return count;
        }


        public void Join(Graf1 g1)
        {
            for (int i = 0; i < edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }
        }


        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (var edge in edges)
            {
                result.AppendLine(edge.ToString());
            }

            return result.ToString();
        }
    }
}
