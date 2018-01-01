using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ZenstAcademy.Resources
{
   public class CourseResource
    {
        public int Id { get; set; }

        public string CourseCode { get; set; }

        public string CourseTitle { get; set; }

        public ICollection<CourseRegisterResource> ClassList { get; set; }

        public CourseResource()
        {
            ClassList = new Collection<CourseRegisterResource>();
        }
    }
}