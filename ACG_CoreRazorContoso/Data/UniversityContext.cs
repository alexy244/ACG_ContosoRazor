using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ACG_CoreRazorContoso.Models;

namespace ACG_CoreRazorContoso.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        public DbSet<Enrollment> Enrollment { get; set; }
    }
}
