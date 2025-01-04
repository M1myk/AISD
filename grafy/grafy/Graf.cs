using System.Collections.Generic;

namespace grafy
{
    internal class Graf
    {
        List<NodeG> nodes = new List<NodeG>(); 

        
       

        public List<NodeG> Wezel(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>() { start }; 
            

            for(int i = 0; i < odwiedzone.Count;i++)
            {
                var temp = odwiedzone[i];
                for(int j = 0; j < temp.sasiedzi.Count;j++)
                {
                    if(!odwiedzone.Contains(temp.sasiedzi[j]))
                    {
                        odwiedzone.Add(temp.sasiedzi[j]);
                    }
                }
            }

            return odwiedzone; 
        }
    }
}
