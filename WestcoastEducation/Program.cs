using WestcoastEducation.Enum;
using WestcoastEducation.Interfaces;
using WestcoastEducation.Manager;
using WestcoastEducation.Models;
using WestcoastEducation.Storage;

namespace WestcoastEducation
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Course csharpCourse = new Course(
                    courseNumber: 101,
                    title: "C# Grundkurs",
                    duration: 8,
                    startDate: new DateTime(2026,11,2),
                    endDate: new DateTime(2026,12,8),
                    typeOfCourse: CourseType.Distance
                    );

                Course oopCourse = new Course(
                    courseNumber: 102,
                    title: "Objektorienterad programmering",
                    duration: 10,
                    startDate: new DateTime(2026, 11, 2),
                    endDate: new DateTime(2026, 12, 8),
                    typeOfCourse: CourseType.Classroom
                    );

            CourseManager courseManager = new CourseManager();

            ICourseStorage storage = new JsonCourseStorage();

            List<Course> loadedCourses = storage.LoadCourses();

            foreach (Course course in loadedCourses)
            {
                courseManager.AddCourse(course);
            }

            if (loadedCourses.Count == 0)
            {
                courseManager.AddCourse(csharpCourse);
                courseManager.AddCourse(oopCourse);

                storage.SaveCourses(courseManager.GetCourses());
            }

            Student student = new Student(
                    firstName: "Murat",
                    lastName: "Buyuksal",
                    phoneNumber: "070-123 45 67",
                    personalNumber: "19900101-1234",
                    address: "Storgatan 1",
                    postalCode: "123 45",
                    city: "Göteborg"
                );

                Student student2 = new Student(
                    firstName: "Simon",
                    lastName: "Kovac",
                    phoneNumber: "070-987 65 43",
                    personalNumber: "19850505-5678",
                    address: "Bäckestigatan 2",
                    postalCode: "543 21",
                    city: "Malmö"
                );
                StudentManager studentManager = new StudentManager();
                studentManager.AddStudent(student);
                studentManager.AddStudent(student2);

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
                teacher.AddCourse(csharpCourse);

                EducationManager educationManager = new EducationManager(
                    firstName: "Ben",
                    lastName: "Bensson",
                    phoneNumber: "070-111 11 11",
                    personalNumber: "19800606-1234",
                    address: "Utbildningstigen 4",
                    postalCode: "987 65",
                    city: "Stockholm",
                    knowledgeArea: "Utbildning",
                    employmentDate: new DateTime(2020, 1, 1)
                );

                Administrator administrator = new Administrator(
                    firstName: "Christian",
                    lastName: "Vieri",
                    phoneNumber: "070-222 22 22",
                    personalNumber: "19700101-5678",
                    address: "Administrationsvägen 5",
                    postalCode: "543 21",
                    city: "Milano",
                    knowledgeArea: "Administration",
                    employmentDate: new DateTime(2020, 1, 1)
                );

                Console.WriteLine("========== WESTCOAST EDUCATION ==========");

                Console.WriteLine("\n========== KURSER ==========");
                courseManager.ShowCourses();
                Console.WriteLine($"Totalt antal kurser: {courseManager.GetCourseCount()}");

                Console.WriteLine("\n========== STUDENTER ==========");
                studentManager.ShowStudents();
                Console.WriteLine($"Totalt antal studenter: {studentManager.GetStudentCount()}");

                Console.WriteLine("\n========== PERSONAL ==========");
                Console.WriteLine("\n--- Lärare ---");
                Console.WriteLine(teacher);
                Console.WriteLine($"Ansvarar för antal kurser: {teacher.Courses.Count}");

                Console.WriteLine("\n--- Utbildningsledare ---");
                Console.WriteLine(educationManager);

                Console.WriteLine("\n--- Administratör ---");
                Console.WriteLine(administrator);
            
                
                    Console.ReadKey();
            }
        }
    }
