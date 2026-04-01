using System;

namespace lvl3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення таблиці
            HashTableDelete myTable = new HashTableDelete(10);

            // Вставка елементів з різними довжинами
            myTable.Insert(new Vector(1, 1));   // Довжина ~1.41
            myTable.Insert(new Vector(5, 5));   // Довжина ~7.07
            myTable.Insert(new Vector(8, 0));  // Довжина 8.0
            myTable.Insert(new Vector(0.5, 0.5)); // Довжина ~0.71

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Вміст таблиці до видалення:");
            Console.ResetColor();
            myTable.PrintTable();
            

            // Видалення за критерієм (наприклад, довжина > 5)
            myTable.RemoveByLength(5.0);

            // 4Вивід після видалення
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nВміст таблиці після видалення:");
            Console.ResetColor();
            myTable.PrintTable();
            

            Console.ReadKey();
        }
    }
}