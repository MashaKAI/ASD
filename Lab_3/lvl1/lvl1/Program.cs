using System;

namespace lvl1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BinaryTree tree = new BinaryTree();

            // Додаємо студентів
            tree.Insert(new Student("Іванов", "Іван", 2, 205, new DateTime(2005, 5, 10)));
            tree.Insert(new Student("Петров", "Олег", 1, 101, new DateTime(2006, 3, 15)));
            tree.Insert(new Student("Сидоренко", "Анна", 3, 310, new DateTime(2004, 11, 20)));
            tree.Insert(new Student("Коваль", "Максим", 2, 215, new DateTime(2005, 8, 5)));

            // Шапка таблиці
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{"ID",-10} | {"Прізвище",-12} | {"Ім'я",-10} | {"Курс",-5} | {"Дата нар.",-10}");
            Console.WriteLine(new string('-', 60));

            // Вивід вмісту за допомогою рекурсивного DFS
            tree.DisplayDFS(tree.Root);

            Console.WriteLine(new string('-', 60));
            Console.ReadKey();
        }
    }
}