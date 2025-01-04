

namespace dodanie_elementu
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count = 0;

        
        public void AddLast(int liczba)
        {
            Node add = new Node(liczba);

            if (head == null) 
            {
                head = add;
                tail = add;
            }
            else
            {
                tail.next = add;
                add.prev = tail;
                tail = add;
            }

            count++;
        }

        public Node RemoweLast()
        {
            if(this.head == null)
            {

                return null;

            }

            Node wynik;
            if(this.head == this.tail)
            {
                wynik = this.head;
                this.head = this.tail = null;
                this.count = 0;
                return wynik;
            }

            wynik = this.tail;
            this.tail = this.tail.prev;
            this.tail.next = null;
            wynik.prev = null;
            this.count--;
            
          
            
            return wynik;
        }

        public string intToString()
        {

            var temp = head;
            string wynik = "";

            while( temp != null )
            {               
                wynik += " "+temp.data;
                temp = temp.next;

                
            }

            return wynik.Trim();
        }

        
        public string GetListAsString()
        {
            Node current = head;
            string elements = "";
            while (current != null)
            {
                elements += current.data;
                if (current.next != null)
                {
                    elements +=  ", ";
                    
                } 
                current = current.next;
            }
            return elements;
        }
    }
}
