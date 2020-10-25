using Clean.ApplicationCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        void Create( CourseViewModel courseViewModel );
    }
}
