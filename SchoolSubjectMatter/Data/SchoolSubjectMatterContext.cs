using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSubjectMatter.Models;

namespace SchoolSubjectMatter.Data
{
    public class SchoolSubjectMatterContext : DbContext
    {
        public SchoolSubjectMatterContext (DbContextOptions<SchoolSubjectMatterContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolSubjectMatter.Models.Student> Student { get; set; } = default!;
        public DbSet<SchoolSubjectMatter.Models.Teacher> Teacher { get; set; } = default!;
        public DbSet<SchoolSubjectMatter.Models.Subject> Subject { get; set; } = default!;
        public DbSet<SchoolSubjectMatter.Models.Mark> Mark { get; set; } = default!;
    }
}
