using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ZenstAcademy.Resources;

namespace ZenstAcademy.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string StudentNumber { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public Student()
        {
            var helper = new HelperFunctions();
            StudentNumber = helper.GenerateStudentNumber(this.Id);
        }
    }
}
