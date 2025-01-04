using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace dodanie_elementu
{
    internal class BST
    {
        public NodeT root;


        public void add(int liczba)
        {
            NodeT dziecko = new NodeT(liczba);

            if (root == null)
            {
                this.root = dziecko;
                return;
            }


            NodeT rodzic = SzukajRodzica(dziecko);
            dziecko.rodzic = rodzic;

            if (rodzic.data > dziecko.data)
            {
                rodzic.lewe = dziecko;
            }
            else
            {
                rodzic.prawe = dziecko;
            }

        }

        NodeT SzukajRodzica(NodeT dziecko)
        {
            var temp = root;

            while (true)
            {
                if (temp.data > dziecko.data)
                {
                    if (temp.lewe == null)
                    {

                        return temp;
                    }
                    else
                    {
                        temp = temp.lewe;
                    }
                }
                else
                {
                    if (temp.prawe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.prawe;
                    }
                }
            }

        }

        void CPD(NodeT wezel)
        {
            if (wezel == null)
                return;

            CPD(wezel.lewe);

            CPD(wezel.prawe);

        }
        

        void RemoveElement0(NodeT n) //usuwa zwiazek z rodzicem
        {
            if (this.root == n)
            {
                this.root = null;
            }
            
            else
            {
                if (n.rodzic.lewe == n)
                {
                    n.rodzic.lewe = null;
                }
                else if(n.rodzic.prawe == n)
                {
                    n.rodzic.prawe = null;
                }
                n.rodzic = null;
            }
        }

        public NodeT RemoveElement1(NodeT n) // usuwa zwiazek z dzieckiem
        {
            NodeT dziecko = null;
            if (n.lewe != null)
            {
                dziecko = n.lewe;

            }
            else if (n.prawe != null)
            {
                dziecko = n.prawe;
            }
            this.RemoveElement0(dziecko);
            
            return dziecko;
        }

        public void RemoveElement(NodeT n)
        {
            NodeT temp;
            switch(n.liczbaDzieci())
            {
                case 0:
                    break;

                case 1:
                    temp = this.Min(n.prawe);
                    var dziecko = this.RemoveElement1(temp);
                    var rodzic = temp.rodzic;
                    this.RemoveElement0(temp);
                    if (rodzic == n)
                    {
                        rodzic.PolaczPrawe(dziecko);
                    }
                    else
                    {
                        rodzic.PolaczLewe(dziecko);
                    }
                    break;
                case 2:
                    temp = Min(n.prawe); 
                    RemoveElement(temp);

                    temp.rodzic = n.rodzic;
                    n.rodzic = null;

                    temp.lewe = n.lewe;
                    n.lewe = null;

                    temp.prawe = n.prawe;
                    n.prawe = null;
                    break;
           
            }
        }

        

        public NodeT Min(NodeT n)
        {
            var temp = n;
            while (temp != null)
            {
                temp = temp.lewe;
            }
            return temp;
        }



        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreorderHelper(root, result);
            return result;
        }

        private void PreorderHelper(NodeT wezel, List<int> result)
        {
            if (wezel == null)
                return;

            result.Add(wezel.data);
            PreorderHelper(wezel.lewe, result);
            PreorderHelper(wezel.prawe, result);
        }


        public List<int> inOrder()
        {
            List<int> result = new List<int>();
            InOrderHelper(root, result); 

            return result;

        }

        public void InOrderHelper(NodeT wezel, List<int> result)
        {
            if(wezel == null)
                return;
            
            InOrderHelper(wezel.lewe, result);
            result.Add(wezel.data);
            InOrderHelper(wezel.prawe, result);
        }

        public List<int> postOrder()
        {
            List<int> result = new List<int>();
            postHelper(root, result);

            return result;

        }

        public void postHelper(NodeT wezel, List<int> result)
        {
            if (wezel == null)
                return;

            postHelper(wezel.lewe, result);
            postHelper(wezel.prawe, result);
            result.Add(wezel.data);
        }
    }
}
