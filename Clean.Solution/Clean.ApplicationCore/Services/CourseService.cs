using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.ViewModels;
using Clean.Domain.Commands;
using Clean.Domain.Core.Bus;
using Clean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus; 
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseRepository = courseRepository;
            _bus = bus;
        }

        public void Create( CourseViewModel courseViewModel )
        {
            var createCourseCommand = new CreateCourseCommand(
                courseViewModel.Name, 
                courseViewModel.Description, 
                courseViewModel.ImageURL
                );
            _bus.SendCommand(createCourseCommand);
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
