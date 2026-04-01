using System;

namespace lvl1
{
    public class SortHandler
    {
        public static void SelectionSort(Student[] students)
        {
            int n = students.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (string.Compare(students[j].LastName, students[minIndex].LastName) < 0)
                    {
                        minIndex = j;
                    }
                }

                Student temp = students[minIndex];
                students[minIndex] = students[i];
                students[i] = temp;
            }
        }
    }
}