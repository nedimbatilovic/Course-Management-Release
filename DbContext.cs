using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Course_Management_Release
{
    public class CourseManagementDbContext : DbContext
    {
        public DbSet<Attendant> AttendantSet { get; set; }
        public DbSet<Course> CourseSet { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-66FR0F1;Initial Catalog=CourseManagementBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Attendant o = new Attendant();
            modelBuilder.Entity<Attendant>().HasKey(o => o.Id);
            modelBuilder.Entity<Attendant>().Property(nameof(o.Name)).IsRequired();
            modelBuilder.Entity<Attendant>().Property(nameof(o.Surname)).IsRequired();
            modelBuilder.Entity<Attendant>().Property(nameof(o.Age)).IsRequired();
            base.OnModelCreating(modelBuilder);

            Course c = new Course();
            modelBuilder.Entity<Course>().HasKey(c => c.Id);
            modelBuilder.Entity<Course>().Property(nameof(c.Name)).IsRequired();
            modelBuilder.Entity<Course>().Property(nameof(c.DurationStart)).IsRequired();
            modelBuilder.Entity<Course>().Property(nameof(c.DurationEnd)).IsRequired();
        }


    }
}
