using Portfolio.Core;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAllCoursesToDo();
        IEnumerable<Course> GetAllCoursesDone();

        Course GetCourseById(int courseId);

        Course AddCourse(Course course);
        Course UpdateCourse(Course course);

        int Commit();
    }
}
