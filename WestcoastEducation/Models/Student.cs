namespace WestcoastEducation.Models
{
    public class Student : Person
    {

        public Student(string firstName, string lastName, string phoneNumber, string personalNumber, string address, string postalCode, string city)
            : base(firstName, lastName, phoneNumber, personalNumber, address, postalCode, city)
        {

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetStudentInfo()
        {
            return $"Student: {GetFullName()}, Telefon: {PhoneNumber}, Adress: {Address}, {PostalCode} {City}";
        }
    }
}
