namespace lvl2
{
    public class Node
    {
        public Student Data;
        public Node Next;
        public Node Previous;

        public Node(Student student)
        {
            Data = student;
            Next = null;
            Previous = null;
        }
    }
}