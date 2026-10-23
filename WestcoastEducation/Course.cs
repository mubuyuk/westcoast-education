namespace WestcoastEducation
{
    public class Course
    {
        public int CourseNumber { get; set; }
        public string Title { get; set; }
        public int Duration  { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CourseType TypeOfCourse { get; set; }

        public Course(int courseNumber, string title, int duration, DateTime startDate, DateTime endDate, CourseType typeOfCourse)
        {
            CourseNumber = courseNumber;
            Title = title;
            Duration = duration;
            StartDate = startDate;
            EndDate = endDate;
            TypeOfCourse = typeOfCourse;
        }

        public string GetCourseInfo()
        {
            return $"Kurs nummer: {CourseNumber}, Titel: {Title}, Duration: {Duration} veckor, Start Datum: {StartDate.ToShortDateString()}, Slut Datum: {EndDate.ToShortDateString()}, Kurs typ: {TypeOfCourse}";
        }
    }
}
