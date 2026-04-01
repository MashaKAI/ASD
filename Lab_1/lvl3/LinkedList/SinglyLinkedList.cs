using System;

namespace lvl3.LinkedList
{
    public class SinglyLinkedList
    {
        public Node Head;

        public void Add(int data)
        {
            if (Head == null) { Head = new Node(data); return; }
            Node current = Head;
            while (current.Next != null) current = current.Next;
            current.Next = new Node(data);
        }

        public void Print()
        {
            if (Head == null) { Console.WriteLine("Список порожній"); return; }
            Node current = Head;
            while (current != null)
            {
                Console.Write($"[{current.Data}] -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}