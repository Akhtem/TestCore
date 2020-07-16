using AutoMapper;
using BusinessLogic.Resources.Course;
using CourseManager.Resources.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManager.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CourseResource, CourseModel>();
            CreateMap<CourseModel, CourseResource>();
            CreateMap<SaveCourseModel, CourseResource>();
        }
    }
}
