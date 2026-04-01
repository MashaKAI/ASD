using System;

namespace lvl2
{
    public class DoublyLinkedList
    {
        public Node Head;

        public void Add(Student student)
        {
            Node newNode = new Node(student);
            if (Head == null)
            {
                Head = newNode;
                return;
            }
            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Previous = current;
        }

        public void SortByLastName()
        {
            if (Head == null) return;

            Node i = Head;
            while (i != null)
            {
                Node minNode = i;
                Node j = i.Next;

                while (j != null)
                {
                    if (string.Compare(j.Data.LastName, minNode.Data.LastName) < 0)
                    {
                        minNode = j;
                    }
                    j = j.Next;
                }

                Student temp = i.Data;
                i.Data = minNode.Data;
                minNode.Data = temp;

                i = i.Next;
            }
        }

        public void PrintAll()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine($"{current.Data.LastName,-12} | {current.Data.FirstName,-10} | {current.Data.StudyForm}");
                current = current.Next;
            }
        }
    }
}