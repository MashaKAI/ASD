using System;

namespace lvl3
{
    public class QuickSortHandler
    {
        public static void Sort(Student[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);

                Sort(array, left, pivotIndex - 1);
                Sort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(Student[] array, int left, int right)
        {
            Student pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (string.Compare(array[j].LastName, pivot.LastName) < 0)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void Swap(Student[] array, int a, int b)
        {
            Student temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}