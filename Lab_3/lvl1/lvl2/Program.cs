using System;

namespace lvl2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BinaryTreeSearch tree = new BinaryTreeSearch();

            // Додаємо різних студентів
            tree.Add(new Student("Мельник", "Артем", 3, "КВ1234", new DateTime(2004, 7, 15))); // Підходить (3 курс, липень)
            tree.Add(new Student("Антонюк", "Ігор", 3, "КВ1100", new DateTime(2004, 1, 20))); // Не підходить (зима)
            tree.Add(new Student("Шевченко", "Ольга", 3, "КВ1350", new DateTime(2004, 6, 5)));  // Підходить (3 курс, червень)
            tree.Add(new Student("Бондар", "Олена", 2, "КВ1210", new DateTime(2005, 8, 22))); // Не підходить (2 курс)

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- ПОВНИЙ СПИСОК СТУДЕНТІВ ---");
            Console.ResetColor();
            tree.PrintDFS(tree.Root);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- РЕЗУЛЬТАТ ПОШУКУ (3 КУРС + ЛІТО) ---");
            Console.ResetColor();
            tree.SearchByCriteria(tree.Root);

            Console.ReadKey();
        }
    }
}