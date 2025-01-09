namespace grafy1
{
    internal class Edge
    {
        public NodeG1 start;
        public NodeG1 end;
        public int weight;

        public Edge(NodeG1 start, NodeG1 end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"{start} --({weight})--> {end}";
        }
    }
}
