using _12_EducationDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EducationDB.Context
{
    public class EducationDbContext:DbContext
    {
        public DbSet<Student>Students { get; set; } 
        public DbSet<StudentDetail> StudentsDetail { get; set;}
        public DbSet<School> Schools { get; set;}
        public DbSet<Lesson> Lessons { get; set; }  
        public DbSet<Laptop> Laptops { get; set; }   
        public DbSet<Department>Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-785CG1C;Initial Catalog=EF-1eEducation;Integrated Security=True;TrustServerCertificate=True");
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Primary Key
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentNo)
                .IsClustered(false);

            modelBuilder.Entity<Student>()
          .Property(s => s.StudentNo)
           .IsRequired();



            //one to Many
            modelBuilder.Entity<Student>()
            .HasOne(s => s.School)
            .WithMany(x => x.Students)
            .HasForeignKey(s => s.SchoolNo);




            modelBuilder.Entity<Student>()
                .Property(s => s.StudentNo)
                .IsRequired(false);


            //Many to many

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Lessons)
                .WithMany(l => l.Students);
            //One to one

            modelBuilder.Entity<Student>()
                .HasOne<Laptop>(s=>s.Laptop)
                .WithOne(l=>l.Studet)
                .HasForeignKey<Laptop>(l=>l.StudentNo)
                .OnDelete(DeleteBehavior.NoAction);

            //One to one
            modelBuilder.Entity<Student>()
                .HasOne<StudentDetail>(s => s.StudenDetail)
                .WithOne(sd => sd.Student)
                .HasForeignKey<StudentDetail>(sd => sd.StudentNo);


            //  modelBuilder.Entity<StudentDetail>()
            //     .HasOne<Student>(sd => sd.Student)
            //    .WithOne(s => s.StudenDetail)
            //    .HasForeignKey<StudentDetail>(sd => sd.StudentNo);
            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);


            modelBuilder.Entity<Student>()
                .Ignore(s => s.Age);


            //Lesson Entity FluentAPI
            modelBuilder.Entity<Lesson>()
                .Property(L=>L.Name)
                .IsRequired()
                .HasMaxLength (50); 

            modelBuilder.Entity <Lesson>()
                .HasKey(l=>l.LessonNo);


            //School Entity FluentAPI

            modelBuilder.Entity<School>()
                .ToTable("Okul");

            modelBuilder.Entity<School>()
                .Property(s => s.Name)
                .HasColumnName("Okul Adı")
                .IsRequired()
                .HasMaxLength(50);

            //Laptop Entity FluentAPI
            modelBuilder.Entity<Laptop>()
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);

            //Department Entity FluentAPI
            modelBuilder.Entity<Department>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity < Department>()
                .HasMany(d => d.Schools)
                .WithMany(s => s.Departments);

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Lessons)
                .WithOne(l => l.Department)
                .HasForeignKey(l => l.DepartmentID);





            base.OnModelCreating(modelBuilder);
        }
    }
}
