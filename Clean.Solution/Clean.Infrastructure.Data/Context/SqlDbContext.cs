using Clean.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Infrastructure.Data.Context
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
