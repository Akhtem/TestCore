using BusinessLogic.DomainServices.Interfaces;
using BusinessLogic.Factories;
using BusinessLogic.Resources.Course;
using EntityFrameworkCore.Abstractions;
using EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace BusinessLogic.DomainServices.Concrete
{
    public class CourseService : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CourseFactory courseFactory;

        public CourseService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            courseFactory = new CourseFactory();
        }

        public async Task<IEnumerable<CourseResource>> GetAllCourses()
        {
            IEnumerable<CourseInfo> courses = await _unitOfWork.CourseInfos
                .GetAllAsync();
            List<CourseResource> courseResources = new List<CourseResource>();

            foreach (CourseInfo course in courses)
            {
                courseResources.Add(courseFactory.Create(course.Course, course.DayOfWeek, course.TimeOfDay));
            }
            return courseResources;

        }
        public async Task<CourseResource> GetCourseById(int id)
        {
            CourseInfo course = await _unitOfWork.CourseInfos
                .GetByIdAsync(id);
            return courseFactory.Create(course.Course, course.DayOfWeek, course.TimeOfDay);
        }
        public async Task<CourseResource> CreateCourse(CourseResource newCourse)
        {
            Course course = new Course { Name = newCourse.Name, Price = newCourse.Price , CreatedOn = DateTime.Now };
            await _unitOfWork.Courses
                .AddAsync(course);
            IEnumerable<Course> courses = await _unitOfWork.Courses.GetAllAsync();
            int newId = courses.OrderByDescending(c => c.Id).Select(id => id.Id).FirstOrDefault();
            await _unitOfWork.CourseInfos
                .AddAsync(new CourseInfo {Id = Guid.NewGuid(), CourseId = newId, CreatedOn = DateTime.Now ,DayOfWeekId = newCourse.DayOfWeekId , TimeOfDayId = newCourse.TimeOfDayId });

            return newCourse;
        }
        public async Task UpdateCourse(CourseResource courseToBeUpdated, CourseResource course)
        {
            Course courseDb = await _unitOfWork.Courses.GetByIdAsync(courseToBeUpdated.Id);
            courseDb.Name = course.Name;
            courseDb.Price = course.Price;

            await _unitOfWork.CommitAsync();
        }
        public async Task DeleteCourse(CourseResource course)
        {
            Course _course = new Course { Id = course.Id, Name = course.Name, Price = course.Price };
            _unitOfWork.Courses.Remove(_course);

            await _unitOfWork.CommitAsync();
        }
    }
}
