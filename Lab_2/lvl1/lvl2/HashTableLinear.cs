using System;

namespace lvl2
{
    public class HashTableLinear
    {
        private Vector[] table;
        private int size;
        private const double A = 0.6180339887;

        public HashTableLinear(int capacity)
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

        // Вставка з лінійним зондуванням
        public void Insert(Vector vector)
        {
            double key = vector.GetAngle();
            int index = CalculateHash(key);
            int startIndex = index; // Запам'ятовуємо, де почали

            while (table[index] != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Колізія в індексі {index}. Шукаємо далі");
                Console.ResetColor();
                index = (index + 1) % size; 

                if (index == startIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Помилка: Таблиця переповнена!");
                    Console.ResetColor();   
                    return;
                }
            }

            table[index] = vector;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Елемент успішно додано в індекс {index}");
            Console.ResetColor();
        }

        public void PrintTable()
        {
            Console.WriteLine("\n--- Зміст хеш-таблиці (Лінійне зондування) ---");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i}: ");
                if (table[i] != null)
                {
                    table[i].Display();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[порожньо]");
                    Console.ResetColor();
                }
            }
        }
    }
}