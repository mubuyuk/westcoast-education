namespace WestcoastEducation
{
    public class CourseManager
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course newCourse)
        {
            if (courses.Exists(c => c.CourseNumber == newCourse.CourseNumber))
            {
                Console.WriteLine($"Kurs med kursnummer {newCourse.CourseNumber} finns redan.");
                return;
            }
            courses.Add(newCourse);
        }

        public void ShowCourses()
        {
            foreach (Course course in courses)
            {
                Console.WriteLine(course.GetCourseInfo());
            }
        }

        public int GetCourseCount()
        {
            return courses.Count;
        }

        public List<Course> GetCourses()
        {
            return new List<Course>(courses);
        }
    }
}
