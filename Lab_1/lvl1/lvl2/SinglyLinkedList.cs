using System;

namespace lvl2
{
    public class SinglyLinkedList
    {
        private Node _head;

        // Вставка елемента в кінець списку
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node current = _head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public bool Remove(int data)
        {
            if (_head == null) 
                return false;

            if (_head.Data == data)
            {
                _head = _head.Next;
                return true;
            }

            Node current = _head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (_head == null)
            {
                Console.WriteLine("Список порожній.");
                return;
            }

            Node current = _head;

            while (current != null)
            {
                // Виводимо значення поточного вузла
                Console.Write("[" + current.Data + "]");

                if (current.Next != null)
                {
                    Console.Write(" -> ");
                }
                else
                {
                    Console.Write(" -> null");
                }

                // Переходимо до наступного вузла 
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
