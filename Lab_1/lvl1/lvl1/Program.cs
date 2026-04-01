using System;
using System.Collections.Generic;

namespace lvl1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення екземпляра структури даних
            MyQueue queue = new MyQueue();

            // Вставка елементів і вивід
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Додавання елементів у чергу");
            Console.ResetColor();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.Write("Вміст черги: ");
            queue.Print();

            // Видалення декількох елементів і вивід
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nВидалення 2-х елементів (10 та 20)");
            Console.ResetColor();
            queue.Dequeue();
            queue.Dequeue();

            Console.Write("Вміст черги після видалення: ");
            queue.Print();

            Console.ReadLine();
        }
    }
}