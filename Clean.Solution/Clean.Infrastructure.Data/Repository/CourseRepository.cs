using Clean.Domain.Interfaces;
using Clean.Domain.Models;
using Clean.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private SqlDbContext _context;

        public CourseRepository(SqlDbContext context)
        {
            this._context = context;
        }

        public void Add( Course course )
        {
            _context.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
