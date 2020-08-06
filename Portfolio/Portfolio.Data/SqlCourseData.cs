using Portfolio.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Data
{
    public class SqlCourseData : ICourseData
    {
        private readonly PortfolioDbContext _context;

        public SqlCourseData(PortfolioDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAllCoursesDone()
        {
            return _context.Courses.Where(c => c.Done == true);
        }

        public IEnumerable<Course> GetAllCoursesToDo()
        {
            return _context.Courses.Where(c => c.Done == false);
        }
    }
}
