using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLogic.Resources.Course;
using EntityFrameworkCore.Entities;

namespace BusinessLogic.DomainServices.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseResource>> GetAllCourses();
        Task<CourseResource> GetCourseById(int id);
        Task<CourseResource> CreateCourse(CourseResource newCourse);
        Task UpdateCourse(CourseResource courseToBeUpdated, CourseResource course);
        Task DeleteCourse(CourseResource course);
    }
}
