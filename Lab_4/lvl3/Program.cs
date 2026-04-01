using System;

namespace lvl3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Student[] students = new Student[]
            {
                new Student("Яковенко", "Іван"),
                new Student("Авраменко", "Анна"),
                new Student("Бойко", "Дмитро"),
                new Student("Гончар", "Ольга"),
                new Student("Мельник", "Артем")
            };

            Console.WriteLine("=== ДО ШВИДКОГО СОРТУВАННЯ ===");
            foreach (var s in students) s.Print();

            // Викликаємо сортування для всього масиву (від 0 до довжина-1)
            QuickSortHandler.Sort(students, 0, students.Length - 1);

            Console.WriteLine("\n=== ПІСЛЯ ШВИДКОГО СОРТУВАННЯ ===");
            foreach (var s in students) s.Print();

            Console.ReadKey();
        }
    }
}