using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CourseRegistrationAPI.Entity.Course;
namespace CourseRegistrationAPI
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ModelContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ModelContext>>()))
            {
                // Look for any movies.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        Coursename = "ASP.NET Core 6.0",
                        Description = "Khoa hoc nang cao lap trinh mang ASP.NET",
                        Requirements = "Kien thuc co ban ve SQL Server, MVC, C#",
                        Startdate = DateTime.Parse("2022-12-12"),
                        Enddate = DateTime.Parse("2023-2-12")
                    },

                    new Course
                    {
                        Coursename = "Unity Advanced",
                        Description = "Khoa hoc nang cao lap trinh Unity",
                        Requirements = "Kien thuc co ban ve C#, OOP.",
                        Startdate = DateTime.Parse("2022-12-12"),
                        Enddate = DateTime.Parse("2023-2-12")
                    },

                    new Course
                    {
                        Coursename = "Business Intelligence",
                        Description = "Khoa hoc xay dung kho du lieu, chuyen doi du lieu thanh thong tin co ich cho doanh nghiep",
                        Requirements = "Kien thuc co ban ve SQL Server, Visual Studio.",
                        Startdate = DateTime.Parse("2022-12-12"),
                        Enddate = DateTime.Parse("2023-2-12")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
