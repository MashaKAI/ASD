using System;

namespace lvl1
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StudyForm { get; set; } // Бюджет або Контракт

        public Student(string lastName, string firstName, string studyForm)
        {
            LastName = lastName;
            FirstName = firstName;
            StudyForm = studyForm;
        }

        public void Print()
        {
            Console.WriteLine($"{LastName,-12} | {FirstName,-10} | {StudyForm}");
        }
    }
}