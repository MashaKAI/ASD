using System;


namespace lvl3.Queue
{
    public class MyQueue
    {
        private int[] items;
        private int count;

        // Конструктор: створюємо масив на 10 місць при старті
        public MyQueue()
        {
            items = new int[10];
            count = 0;
        }

        public void Enqueue(int item)
        {

            if (count == items.Length)
            {
                int newSize = items.Length * 2;

                Array.Resize(ref items, newSize);
            }

            items[count] = item;
            count = count + 1;
        }

        public int Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Помилка: черга порожня!");
                return -1; 
            }

            int firstItem = items[0];

            for (int i = 0; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            count = count - 1;

            return firstItem;
        }

        public int GetLast()
        {
            if (count == 0)
            {
                return 0;
            }
            return items[count - 1];
        }

        public void Print()
        {
            if (count == 0)
            {
                Console.WriteLine("Черга порожня.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(items[i]);
                if (i < count - 1)
                {
                    Console.Write(" <- ");
                }
            }
            Console.WriteLine();
        }
    }
}
