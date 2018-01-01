using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
   public class StudentsController : Controller
    {
        private readonly ZenstAppDbContext context;
        private readonly IMapper mapper;

        public StudentsController(ZenstAppDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            return View();
        }

        [Route("/api/students")]
        [HttpGet]
        public async Task<IEnumerable<StudentResource>> GetAllStudents()
        {
            var students = await this.context.Students.ToListAsync();

            return  mapper.Map<List<Student>, List<StudentResource>>(students);
        }

        [Route("/api/students/{id}")]
        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetById(string id)
        {
            var student = this.context.Students.FirstOrDefault(t => t.StudentNumber == id);
            if (student == null)
            {
                return NotFound();
            }
            return new ObjectResult(mapper.Map<Student, StudentResource>(student));
        }
        [Route("/api/students/bycourse/{id}")]
        [HttpGet("{id}", Name = "GetStudentsByCourse")]
        public async Task<IEnumerable<StudentResource>> GetStudentsByCourseId(int id)
        {
            var students = await this.context.CourseRegisters.Where(t => t.CourseId == id).Select(s => s.Student).ToListAsync();
           

            if (students == null)
            {
                return null;
            }
         
            return mapper.Map<List<Student>, List<StudentResource>>(students);
        }

        [Route("/api/students/add")]
        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            var newStudent = new Student();
            newStudent.FirstName = student.FirstName;
            newStudent.LastName = student.LastName;
            newStudent.DateOfBirth = student.DateOfBirth;

            try
            {
                this.context.Add(newStudent);
                this.context.SaveChanges();
            }
            catch(SqlException ex)
            {
                return Ok(ex.Message);
            }

           


            return Ok(newStudent);
        }
    }
}