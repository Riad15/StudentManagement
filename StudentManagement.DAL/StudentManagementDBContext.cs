using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;

namespace StudentManagement.DAL
{
    public class StudentManagementDBContext : DbContext
    {

        public StudentManagementDBContext(DbContextOptions<StudentManagementDBContext> options): base(options)
        {

        }

        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new Configuration.StudentConfiguration());
        }


    }
}
