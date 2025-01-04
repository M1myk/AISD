using System.Collections.Generic;

namespace grafy
{
    internal class NodeG
    {
        public List<NodeG> sasiedzi = new List<NodeG>(); 
        int data; 

        public NodeG(int liczba) 
        {
            this.data = liczba;
        }

        public override string ToString() 
        {
            return this.data.ToString();
        }
    }
}
