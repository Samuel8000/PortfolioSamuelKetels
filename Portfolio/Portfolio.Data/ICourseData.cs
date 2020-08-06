using Portfolio.Core;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Data
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAllCoursesToDo();
        IEnumerable<Course> GetAllCoursesDone();
    }
}
