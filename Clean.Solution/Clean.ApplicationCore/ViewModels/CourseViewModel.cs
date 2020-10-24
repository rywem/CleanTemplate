using Clean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Clean.Domain.Models.Course> Courses { get; set; }
    }
}
