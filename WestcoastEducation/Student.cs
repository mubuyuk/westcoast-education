namespace WestcoastEducation
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
            return $"Student: {GetFullName()}, Phone: {PhoneNumber}, Address: {Address}, {PostalCode} {City}";
        }
    }
}
