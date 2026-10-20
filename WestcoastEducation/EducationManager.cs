
namespace WestcoastEducation
{
    public class EducationManager : Employee
    {
        public EducationManager(string firstName, string lastName, string phoneNumber, string personalNumber, string address, string postalCode, string city, string knowledgeArea, DateTime employmentDate)
            : base(firstName, lastName, phoneNumber, personalNumber, address, postalCode, city, knowledgeArea, employmentDate)
        {
        }
    }
}
