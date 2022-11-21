using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CourseRegistrationAPI.Entity.Course;
namespace CourseRegistrationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ModelContext _context;
        public CourseController(ModelContext context)
        {
            _context = context;
        }
        // GET: api/course
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _context.Course.ToList();
        }

    }
}
