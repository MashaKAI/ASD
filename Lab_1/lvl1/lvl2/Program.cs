using System;

namespace lvl2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Cтворення екземпляра структури даних
            SinglyLinkedList myList = new SinglyLinkedList();

            // Вставка елементів
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Додавання елементів у список ---");
            Console.ResetColor();
            myList.Add(10);
            myList.Add(25);
            myList.Add(40);
            myList.Add(55);
            myList.Add(70);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Вміст списку: ");

            myList.Print();
            Console.ResetColor();

            // Видалення декількох елементів
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- Видалення елементів 25 та 70 ---");
            Console.ResetColor();
            myList.Remove(25);
            myList.Remove(70);

            // Вивід після видалення
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Вміст після видалення: ");
            
            myList.Print();
            Console.ResetColor();

        }
    }
}