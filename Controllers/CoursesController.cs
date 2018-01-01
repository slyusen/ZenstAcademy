using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZenstAcademy.Models;
using ZenstAcademy.Persistence;
using ZenstAcademy.Resources;

namespace ZenstAcademy.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ZenstAppDbContext context;
        private readonly IMapper mapper; 

        public CoursesController(ZenstAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [Route("/api/courses")]
        [HttpGet]
        public async Task<IEnumerable<CourseResource>> GetAllCourses()
        {
            var courses = await this.context.Courses.Include(c => c.ClassList).ToListAsync();

            return mapper.Map<List<Course>, List<CourseResource>>(courses);
        }

        [Route("/api/courses/{id}")]
        [HttpGet("{id}", Name = "GetCourse")]
        public IActionResult GetCourseById(int id)
        {
            var course = this.context.Courses.FirstOrDefault(t => t.Id == id);
            if (course == null)
            {
                return NotFound();
            }
            return new ObjectResult(mapper.Map<Course, CourseResource>(course));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}