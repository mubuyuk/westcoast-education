namespace WestcoastEducation.Models
{
    public class Employee : Person
    {
        public string KnowledgeArea { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public DateTime EmploymentDate { get; set; }

        public Employee(string firstName, string lastName, string phoneNumber, string personalNumber, string address, string postalCode, string city, string knowledgeArea, DateTime employmentDate)
            : base(firstName, lastName, phoneNumber, personalNumber, address, postalCode, city)
        {
            KnowledgeArea = knowledgeArea;
            EmploymentDate = employmentDate;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Anställd: {EmploymentDate.ToShortDateString()}";
        }
    }
}