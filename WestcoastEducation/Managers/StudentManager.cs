using WestcoastEducation.Models;

namespace WestcoastEducation.Manager
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student newStudent)
        {
            if (students.Exists(s => s.PersonalNumber == newStudent.PersonalNumber))
            {
                Console.WriteLine($"Student med personnummer {newStudent.PersonalNumber} finns redan.");
                return;
            }
            students.Add(newStudent);
        }

        public void ShowStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetStudentInfo());
            }
        }

        public int GetStudentCount()
        {
            return students.Count;
        }
    }
}
