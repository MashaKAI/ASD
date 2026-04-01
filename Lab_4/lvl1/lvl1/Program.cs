using System;

namespace lvl1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Student[] students = new Student[]
            {
                new Student("Шевченко", "Олег", "Бюджет"),
                new Student("Антонюк", "Ігор", "Контракт"),
                new Student("Бондар", "Олена", "Бюджет"),
                new Student("Мельник", "Артем", "Контракт")
            };

            Console.WriteLine("=== ДО СОРТУВАННЯ ===");
            foreach (var s in students) s.Print();

            SortHandler.SelectionSort(students);

            Console.WriteLine("\n=== ПІСЛЯ СОРТУВАННЯ (за прізвищем) ===");
            foreach (var s in students) s.Print();

            Console.ReadKey();
        }
    }
}