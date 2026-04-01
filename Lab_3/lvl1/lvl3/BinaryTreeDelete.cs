using System;
using System.Collections.Generic;

namespace lvl3
{
    public class BinaryTreeDelete
    {
        public Node Root;

        public void Add(Student newStudent)
        {
            if (Root == null)
            {
                Root = new Node(newStudent);
            }
            else
            {
                AddRecursive(Root, newStudent);
            }
        }

        private void AddRecursive(Node current, Student newStudent)
        {
            // Порівнюємо прізвища (алфавіт)
            int comparison = string.Compare(newStudent.LastName, current.Data.LastName);

            if (comparison < 0) // Якщо прізвище "менше" йдемо вліво
            {
                if (current.Left == null)
                    current.Left = new Node(newStudent);
                else
                    AddRecursive(current.Left, newStudent);
            }
            else // Якщо прізвище "більше" йдемо вправо
            {
                if (current.Right == null)
                    current.Right = new Node(newStudent);
                else
                    AddRecursive(current.Right, newStudent);
            }
        }

        public void DeleteByCriteria()
        {
            List<string> namesToRemove = new List<string>();

            FindWhoToDelete(Root, namesToRemove);

            foreach (string name in namesToRemove)
            {
                Console.WriteLine("Видаляємо студента: " + name);
                Root = RemoveByLastName(Root, name);
            }
        }

        private void FindWhoToDelete(Node node, List<string> list)
        {
            if (node == null) 
                return;

            if (node.Data.ShouldBeDeleted())
            {
                list.Add(node.Data.LastName);
            }

            FindWhoToDelete(node.Left, list);
            FindWhoToDelete(node.Right, list);
        }

        private Node RemoveByLastName(Node current, string name)
        {
            if (current == null) 
                return null;

            int cmp = string.Compare(name, current.Data.LastName);

            if (cmp < 0)
            {
                current.Left = RemoveByLastName(current.Left, name);
            }
            else if (cmp > 0)
            {
                current.Right = RemoveByLastName(current.Right, name);
            }
            else
            {
                if (current.Left == null) 
                    return current.Right;
                if (current.Right == null) 
                    return current.Left;

                current.Data = FindSmallest(current.Right);

                current.Right = RemoveByLastName(current.Right, current.Data.LastName);
            }
            return current;
        }

        private Student FindSmallest(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node.Data;
        }

        public void Print(Node node)
        {
            if (node == null) 
                return;

            Print(node.Left);  
            node.Data.PrintRow();
            Print(node.Right);  
        }
    }
}