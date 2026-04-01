using System;

namespace lvl1
{
    public class MyQueue
    {
        private int[] _items;
        private int _count;
        private const int DefaultCapacity = 10;

        public MyQueue()
        {
            _items = new int[DefaultCapacity];
            _count = 0;
        }

        public void Enqueue(int item)
        {
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count] = item;
            _count++;
        }

        public int Dequeue()
        {
            if (_count == 0) throw new InvalidOperationException("Черга порожня");

            int item = _items[0];

            // Зміщуємо всі елементи вліво (векторний спосіб)
            for (int i = 0; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count--;
            return item;
        }

        public void Print()
        {
            if (_count == 0)
            {
                Console.WriteLine("Черга порожня.");
                return;
            }

            for (int i = 0; i < _count; i++)
            {
                Console.Write(_items[i] + (i < _count - 1 ? " <- " : ""));
            }
            Console.WriteLine();
        }
    }
}
