﻿using Clean.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageURL { get; protected set; }
    }
}
