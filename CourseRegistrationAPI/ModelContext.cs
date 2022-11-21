using Microsoft.EntityFrameworkCore;
using CourseRegistrationAPI.Entity.Course;

namespace CourseRegistrationAPI
{
    public partial class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }

    }
}

