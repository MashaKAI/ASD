using System;

namespace lvl2
{
    public class BinaryTreeSearch
    {
        public Node Root;

        public void Add(Student student)
        {
            Root = AddRecursive(Root, student);
        }

        private Node AddRecursive(Node current, Student student)
        {
            if (current == null) return new Node(student);
            if (string.Compare(student.LastName, current.Data.LastName) < 0)
                current.Left = AddRecursive(current.Left, student);
            else
                current.Right = AddRecursive(current.Right, student);
            return current;
        }

        // РЕКУРСИВНИЙ ПОШУК ЗА КРИТЕРІЄМ: 3 курс + літо
        public void SearchByCriteria(Node node)
        {
            if (node == null) return;

            // Перевіряємо поточного студента
            if (node.Data.Course == 3 && node.Data.IsBornInSummer())
            {
                node.Data.PrintAsRow();
            }

            // Йдемо далі по всьому дереву
            SearchByCriteria(node.Left);
            SearchByCriteria(node.Right);
        }

        public void PrintDFS(Node node)
        {
            if (node == null) 
                return;

            PrintDFS(node.Left);

            node.Data.PrintAsRow();

            PrintDFS(node.Right);
        }
    }
}