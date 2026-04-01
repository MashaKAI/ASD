using System;

namespace lvl3
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Course { get; set; }
        public string TicketNumber { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(string lastName, string firstName, int course, string ticket, DateTime birth)
        {
            LastName = lastName;
            FirstName = firstName;
            Course = course;
            TicketNumber = ticket;
            BirthDate = birth;
        }

        // Метод для перевірки критерію (3 курс + літо)
        public bool ShouldBeDeleted()
        {
            bool isThirdCourse = (Course == 3);
            int month = BirthDate.Month;
            bool isSummer = (month >= 6 && month <= 8);

            return isThirdCourse && isSummer;
        }

        public void PrintRow()
        {
            Console.WriteLine($"{LastName,-12} | {FirstName,-10} | {Course,-5} | {TicketNumber,-10} | {BirthDate.ToShortDateString()}");
        }
    }
}