using System;

namespace lvl2
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створюємо невелику таблицю на 5 місць
            HashTableLinear myTable = new HashTableLinear(5);

            // Додаємо вектори
            myTable.Insert(new Vector(1, 0));   // Індекс А
            myTable.Insert(new Vector(0, 1));   // Індекс Б
            myTable.Insert(new Vector(2, 0));   // Можлива колізія з першим
            myTable.Insert(new Vector(10, 5));
            myTable.Insert(new Vector(-1, 2));

            // Виведення результату
            myTable.PrintTable();

            Console.ReadKey();
        }
    }
}