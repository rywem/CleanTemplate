using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.ViewModels;
using Clean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.Services
{
    public class CourseService : ICourseService
    {

        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
