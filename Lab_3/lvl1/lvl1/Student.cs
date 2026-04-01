using System;

namespace lvl1
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Course { get; set; }
        public int StudentId { get; set; } 
        public DateTime BirthDate { get; set; }

        public Student(string lastName, string firstName, int course, int id, DateTime birth)
        {
            LastName = lastName;
            FirstName = firstName;
            Course = course;
            StudentId = id;
            BirthDate = birth;
        }

        public void PrintRow()
        {
            Console.WriteLine($"{StudentId,-10} | {LastName,-12} | {FirstName,-10} | {Course,-5} | {BirthDate.ToShortDateString(),-10}");
        }
    }
}