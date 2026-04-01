using System;

namespace lvl1
{
    public class BinaryTree
    {
        public Node Root;

        public void Insert(Student student)
        {
            Root = InsertRecursive(Root, student);
        }

        private Node InsertRecursive(Node root, Student student)
        {
            if (root == null)
            {
                return new Node(student);
            }

            // Порівнюємо номери студентських квитків
            if (student.StudentId < root.Data.StudentId)
            {
                root.Left = InsertRecursive(root.Left, student);
            }
            else if (student.StudentId > root.Data.StudentId)
            {
                root.Right = InsertRecursive(root.Right, student);
            }

            return root;
        }

        // Рекурсивний DFS 
        public void DisplayDFS(Node node)
        {
            if (node == null) return;

            DisplayDFS(node.Left);

            node.Data.PrintRow();

            DisplayDFS(node.Right);
        }
    }
}