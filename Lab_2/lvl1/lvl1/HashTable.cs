using System;

namespace lvl1
{
    public class HashTable
    {
        private Vector[] table;
        private int size;
        // Константа для методу множення (золотий перетин)
        private const double A = 0.6180339887;

        public HashTable(int capacity)
        {
            size = capacity;
            table = new Vector[size];
        }

        private int CalculateHash(double key)
        {
            double k = Math.Abs(key);
            double temp = k * A;
            double fractionalPart = temp - Math.Floor(temp);
            return (int)Math.Floor(size * fractionalPart);
        }

        // Вставка елемента (відкрита адресація)
        public void Insert(Vector vector)
        {
            double key = vector.GetAngle();

            int index = CalculateHash(key);

            if (table[index] != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Помилка: Колізія за індексом {index} Елемент не вставлено.");
                Console.ResetColor();
                return; 
            }

            table[index] = vector;
            Console.WriteLine($"Елемент вставлено в комірку {index}");
        }

        public void PrintTable()
        {
            Console.WriteLine("Зміст хеш-таблиці:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Комірка {i}: ");
                if (table[i] != null)
                {
                    table[i].Display();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[Вільне місце!!!]");
                    Console.ResetColor();   
                }
            }
        }
    }
}