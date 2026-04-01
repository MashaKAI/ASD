using System;

namespace lvl2
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

        // Перевірка: чи народився студент влітку (червень=6, липень=7, серпень=8)
        public bool IsBornInSummer()
        {
            int month = BirthDate.Month;
            return month >= 6 && month <= 8;
        }

        public void PrintAsRow()
        {
            Console.WriteLine($"{LastName,-12} | {FirstName,-10} | {Course,-5} | {TicketNumber,-10} | {BirthDate.ToShortDateString()}");
        }
    }
}