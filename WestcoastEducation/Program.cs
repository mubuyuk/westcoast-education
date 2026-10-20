namespace WestcoastEducation
{
    internal class Program
    {
        static void ShowCourses(List<Course> courses)
        {
            foreach (Course course in courses)
            {
                Console.WriteLine(course.GetCourseInfo());
            }
        }

        static void AddCourse(List<Course> courses, Course newCourse)
        {
            if (courses.Exists(c => c.CourseNumber == newCourse.CourseNumber))
            {
                Console.WriteLine($"Kurs med kursnummer {newCourse.CourseNumber} finns redan.");
                return;
            }
            courses.Add(newCourse);
        }

        static void ShowStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetStudentInfo());
            }
        }

        static void AddStudent(List<Student> students, Student newStudent)
        {
            if (students.Exists(s => s.PersonalNumber == newStudent.PersonalNumber))
            {
                Console.WriteLine($"Student med personnummer {newStudent.PersonalNumber} finns redan.");
                return;
            }
            students.Add(newStudent);
        }

        static void Main(string[] args)
        {
            Course course = new Course(
                courseNumber: 101,
                title: "C# Grundkurs",
                duration: 8,
                startDate: new DateTime(2026,11,2),
                endDate: new DateTime(2026,12,8),
                typeOfCourse: CourseType.Distance
                );

            Course course2 = new Course(
                courseNumber: 102,
                title: "Objektorienterad programmering",
                duration: 10,
                startDate: new DateTime(2026, 11, 2),
                endDate: new DateTime(2026, 12, 8),
                typeOfCourse: CourseType.Classroom
                );

            List<Course> courses = new List<Course>();
            AddCourse(courses, course);
            AddCourse(courses, course2);

            Console.WriteLine($"Antal kurser: {courses.Count}");

            ShowCourses(courses);



            Student student = new Student(
                firstName: "Anna",
                lastName: "Svensson",
                phoneNumber: "070-123 45 67",
                personalNumber: "19900101-1234",
                address: "Storgatan 1",
                postalCode: "123 45",
                city: "Varberg"
            );

            Student student2 = new Student(
                firstName: "Erik",
                lastName: "Larsson",
                phoneNumber: "070-987 65 43",
                personalNumber: "19850505-5678",
                address: "Bäckestigatan 2",
                postalCode: "543 21",
                city: "Malmö"
            );


            List<Student> students = new List<Student>();
            AddStudent(students, student);
            AddStudent(students, student2);

            ShowStudents(students);

            Console.WriteLine($"Antal studenter: {students.Count}");


            Teacher teacher = new Teacher(
                firstName: "Karin",
                lastName: "Johansson",
                phoneNumber: "070-555 55 55",
                personalNumber: "19751212-9876",
                address: "Lärargatan 3",
                postalCode: "678 90",
                city: "Göteborg",
                knowledgeArea: "Programmering",
                employmentDate: new DateTime(2020, 1, 1)
            );

            teacher.AddCourse(course);

            Console.WriteLine($"Antal kurser: {teacher.Courses.Count}");


            EducationManager educationManager = new EducationManager(
                firstName: "Maria",
                lastName: "Andersson",
                phoneNumber: "070-111 11 11",
                personalNumber: "19800606-1234",
                address: "Utbildningstigen 4",
                postalCode: "987 65",
                city: "Stockholm",
                knowledgeArea: "Utbildning",
                employmentDate: new DateTime(2020, 1, 1)
            );

            Console.WriteLine($"Utbildningsledare: {educationManager.FirstName} {educationManager.LastName}, Anställningsdatum: {educationManager.EmploymentDate.ToShortDateString()}");

            Administrator administrator = new Administrator(
                firstName: "Lars",
                lastName: "Nilsson",
                phoneNumber: "070-222 22 22",
                personalNumber: "19700101-5678",
                address: "Administrationsvägen 5",
                postalCode: "543 21",
                city: "Uppsala",
                knowledgeArea: "Administration",
                employmentDate: new DateTime(2020, 1, 1)
            );

            Console.WriteLine($"Administratör: {administrator.FirstName} {administrator.LastName}, Kunskapsområde: {administrator.KnowledgeArea}, Anställningsdatum: {administrator.EmploymentDate.ToShortDateString()}");
            Console.ReadKey();
        }
    }
}
