﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageURL)
        {
            Name = name;
            Description = description;
            ImageURL = imageURL;
        }
    }
}
