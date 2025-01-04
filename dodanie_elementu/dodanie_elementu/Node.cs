namespace dodanie_elementu
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int liczba)
        {
            this.data = liczba;
        }
    }
}
