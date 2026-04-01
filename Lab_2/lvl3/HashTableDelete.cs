using System;

namespace lvl3
{
    public class HashTableDelete
    {
        private Vector[] table;
        private int size;
        private const double A = 0.6180339887;

        public HashTableDelete(int capacity)
        {
            size = capacity;
            table = new Vector[size];
        }

        private int CalculateHash(double key)
        {
            double k = Math.Abs(key);
            double temp = k * A;
            return (int)Math.Floor(size * (temp - Math.Floor(temp)));
        }

        public void Insert(Vector vector)
        {
            int index = CalculateHash(vector.GetAngle());
            int startIndex = index;

            while (table[index] != null)
            {
                index = (index + 1) % size;
                if (index == startIndex) return;
            }
            table[index] = vector;
        }

        // МЕТОД ВИДАЛЕННЯ ЗА КРИТЕРІЄМ
        public void RemoveByLength(double maxLength)
        {
            Console.WriteLine($"\n--- Видалення векторів довжиною більше ніж {maxLength} ---");
            for (int i = 0; i < size; i++)
            {
                if (table[i] != null && table[i].GetLength() > maxLength)
                {
                    Console.WriteLine($"Видалено з комірки {i}: довжина {table[i].GetLength():F2}");
                    table[i] = null; // Видаляємо елемент
                }
            }
        }

        public void PrintTable()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i}: ");
                if (table[i] != null)
                {
                    table[i].Display();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[порожньо]");
                    Console.ResetColor();
                }
            }
        }
    }
}