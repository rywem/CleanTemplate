using Clean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.ViewModels
{
    public class CourseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public IEnumerable<Clean.Domain.Models.Course> Courses { get; set; }
    }
}
