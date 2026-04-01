namespace lvl3
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Student(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public void Print()
        {
            Console.WriteLine($"{LastName,-12} | {FirstName}");
        }
    }
}