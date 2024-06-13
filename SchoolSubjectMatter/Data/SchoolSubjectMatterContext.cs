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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurare relații Many-to-Many pentru Students și Subjects
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Subjects)
                .WithMany(s => s.Students)
                .UsingEntity(j => j.ToTable("StudentSubjects"));

            // Configurare relații Many-to-Many pentru Teachers și Subjects
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Subjects)
                .WithMany(s => s.Teachers)
                .UsingEntity(j => j.ToTable("TeacherSubjects"));

            // Configurare relații One-to-Many pentru Marks și Students
            modelBuilder.Entity<Mark>()
                .HasOne(m => m.Student)
                .WithMany(s => s.Marks)
                .HasForeignKey(m => m.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configurare relații One-to-Many pentru Marks și Subjects
            modelBuilder.Entity<Mark>()
                .HasOne(m => m.Subject)
                .WithMany(s => s.Marks)
                .HasForeignKey(m => m.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configurare relații One-to-Many pentru Marks și Teachers
            modelBuilder.Entity<Mark>()
                .HasOne(m => m.Teacher)
                .WithMany(t => t.Marks)
                .HasForeignKey(m => m.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
