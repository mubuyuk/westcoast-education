namespace WestcoastEducation.Models
{
    public class Teacher : Employee
    {

        public Teacher(string firstName, string lastName, string phoneNumber, string personalNumber, string address, string postalCode, string city, string knowledgeArea, DateTime employmentDate)
            : base(firstName, lastName, phoneNumber, personalNumber, address, postalCode, city, knowledgeArea, employmentDate)
        {

        }

        public void AddCourse(Course newCourse)
        {
            if (!Courses.Contains(newCourse))
            {
                Courses.Add(newCourse);
            }
        }
    }
}
