using Microsoft.EntityFrameworkCore;
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

        public Course AddCourse(Course course)
        {
            _context.Courses.Add(course);
            return course;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCoursesDone()
        {
            return _context.Courses
                .Include(c => c.Skill)
                .Where(c => c.Done == true);
        }

        public IEnumerable<Course> GetAllCoursesToDo()
        {
            return _context.Courses
                .Include(c => c.Skill)
                .Where(c => c.Done == false);
        }

        public Course GetCourseById(int courseId)
        {
            return _context.Courses.Find(courseId);
        }

        public Course UpdateCourse(Course course)
        {
            var entity = _context.Courses.Attach(course);
            entity.State = EntityState.Modified;
            return course;
        }
    }
}
