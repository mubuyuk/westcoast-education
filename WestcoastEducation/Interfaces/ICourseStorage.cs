using WestcoastEducation.Models;

namespace WestcoastEducation.Interfaces
{
    public interface ICourseStorage
    {
        void SaveCourses(List<Course> courses);

        List<Course> LoadCourses();
    }
}
