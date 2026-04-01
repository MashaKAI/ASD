using System;

namespace lvl3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BinaryTreeDelete tree = new BinaryTreeDelete();

            // Тестові дані
            tree.Add(new Student("Білий", "Іван", 3, "К-01", new DateTime(2004, 7, 10)));  // Видалити (3 курс, літо)
            tree.Add(new Student("Авраменко", "Яна", 1, "К-02", new DateTime(2006, 5, 20))); // Залишити
            tree.Add(new Student("Зінченко", "Олег", 3, "К-03", new DateTime(2004, 6, 15))); // Видалити (3 курс, літо)
            tree.Add(new Student("Дмитренко", "Анна", 2, "К-04", new DateTime(2005, 8, 25))); // Залишити (2 курс)

            Console.WriteLine("--- СПИСОК ДО ВИДАЛЕННЯ ---");
            tree.Print(tree.Root);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--- ПРОЦЕС ВИДАЛЕННЯ ---");
            tree.DeleteByCriteria();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--- СПИСОК ПІСЛЯ ВИДАЛЕННЯ ---");
            tree.Print(tree.Root);
            Console.ResetColor();

        }
    }
}