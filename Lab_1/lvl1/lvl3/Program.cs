using lvl3.LinkedList;
using lvl3.Queue;
using System;

namespace lvl3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення екземплярів
            SinglyLinkedList list = new SinglyLinkedList();
            MyQueue queue = new MyQueue();

            // Вставка елементів у список 
            list.Add(5); 
            list.Add(-3);
            list.Add(10);  
            list.Add(2);   
            list.Add(-8);  
            list.Add(4);   

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Початковий вміст списку ---");
            
            list.Print();
            Console.ResetColor();

            // Формування черги згідно із завданням
            Node current = list.Head;
            while (current != null)
            {
                if (current.Data > 0) // Тільки додатні елементи
                {
                    int lastQueueElement = queue.GetLast();
                    int newValue = lastQueueElement + current.Data;
                    queue.Enqueue(newValue);
                }
                current = current.Next;
            }

            Console.ForegroundColor = ConsoleColor.Green;   
            Console.WriteLine("\n--- Вміст списку (після обробки) ---");
            list.Print();

            Console.WriteLine("\n--- Вміст черги (суми) ---");
            
            queue.Print();
            Console.ResetColor();

        }
    }
}