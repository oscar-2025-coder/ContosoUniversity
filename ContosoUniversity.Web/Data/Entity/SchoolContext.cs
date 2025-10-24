using ContosoUniversity.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Web.Data;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions <SchoolContext> options) : base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    
}