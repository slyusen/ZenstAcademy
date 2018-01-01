using Microsoft.EntityFrameworkCore;
using ZenstAcademy.Models;

namespace ZenstAcademy.Persistence
{
    public class ZenstAppDbContext : DbContext
    {
        public ZenstAppDbContext(DbContextOptions<ZenstAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseRegister> CourseRegisters { get; set; }
    }
}