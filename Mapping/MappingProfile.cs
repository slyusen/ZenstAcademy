using ZenstAcademy.Resources;
using AutoMapper;
using ZenstAcademy.Models;

namespace ZenstAcademy.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentResource>();
            CreateMap<Course, CourseResource>();
            CreateMap<CourseRegister, CourseRegisterResource>();
        }
    }
}