using System;

namespace lvl1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створюємо таблицю розміром 10
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- Створюємо хеш-таблицю розміром 10 ---");
            Console.WriteLine("      --- Вставляємо 4 елемента ---");
            Console.WriteLine();
            Console.ResetColor();
            HashTable myTable = new HashTable(10);

            Vector v1 = new Vector(1, 0);   // Кут 0
            Vector v2 = new Vector(0, 1);   // Кут 1.57
            Vector v3 = new Vector(-1, -1); // Кут -2.35
            Vector v4 = new Vector(5, 2);   // Інший кут

            // Вставка
            myTable.Insert(v1);
            myTable.Insert(v2);
            myTable.Insert(v3);
            myTable.Insert(v4);

            // Виведення результату
            Console.WriteLine();
            myTable.PrintTable();

        }
    }
}