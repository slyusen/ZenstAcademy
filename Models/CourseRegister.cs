using System.ComponentModel.DataAnnotations.Schema;

namespace ZenstAcademy.Models
{
    public class CourseRegister
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public string Term { get; set; }

        public string Year { get; set; }
    }
}