using System;

namespace lvl2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DoublyLinkedList list = new DoublyLinkedList();

            list.Add(new Student("Яковенко", "Іван", "Бюджет"));
            list.Add(new Student("Авраменко", "Анна", "Контракт"));
            list.Add(new Student("Бойко", "Дмитро", "Бюджет"));
            list.Add(new Student("Гончар", "Ольга", "Контракт"));

            Console.WriteLine("=== СПИСОК ДО СОРТУВАННЯ ===");
            list.PrintAll();

            list.SortByLastName();

            Console.WriteLine("\n=== СПИСОК ПІСЛЯ СОРТУВАННЯ (Selection Sort) ===");
            list.PrintAll();

            Console.ReadKey();
        }
    }
}