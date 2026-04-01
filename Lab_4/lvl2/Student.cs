namespace lvl2
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StudyForm { get; set; }

        public Student(string lastName, string firstName, string studyForm)
        {
            LastName = lastName;
            FirstName = firstName;
            StudyForm = studyForm;
        }
    }
}