using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ZenstAcademy.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string CourseCode { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseTitle { get; set; }

        public ICollection<CourseRegister> ClassList { get; set; }

        public Course()
        {
            ClassList = new Collection<CourseRegister>();
        }
    }

}