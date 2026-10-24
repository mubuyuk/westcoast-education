using System.Text.Encodings.Web;
using System.Text.Json;
using WestcoastEducation.Interfaces;
using WestcoastEducation.Models;

namespace WestcoastEducation.Storage
{
    public class JsonCourseStorage : ICourseStorage
    {
        JsonSerializerOptions options = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        
        string path = Path.GetFullPath(
            Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Data", "courses.json")
        );

        public List<Course> LoadCourses()
        {
            if (!File.Exists(path))
            {
                return new List<Course>();
            }
            string jsonFromFile = File.ReadAllText(path);

            var loadedCourses = JsonSerializer.Deserialize<List<Course>>(jsonFromFile, options);

            return loadedCourses ?? new List<Course>();
        }

        public void SaveCourses(List<Course> courses)
        {
            // Convert to JSON
            string json = JsonSerializer.Serialize(courses, options);

            // Save JSON to file
            File.WriteAllText(path, json);
        }
    }
}
