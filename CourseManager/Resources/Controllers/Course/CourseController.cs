using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.DomainServices.Interfaces;
using BusinessLogic.Resources.Course;
using CourseManager.Resources.Models;
using CourseManager.Validators;
using Microsoft.AspNetCore.Mvc;

namespace CourseManager.Resources.Controllers.Course
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService courseService, IMapper mapper)
        {
            this._courseService = courseService;
            this._mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllCourses();
            var courseResources = _mapper.Map<IEnumerable<CourseResource>, IEnumerable<CourseModel>>(courses);
            return View(courseResources);
        }

        public async Task<ActionResult> Create([FromBody] SaveCourseModel course)
        {
            var validator = new SaveCourseModelValidator();
            var validationResult = await validator.ValidateAsync(course);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var courseToCreate = _mapper.Map<SaveCourseModel, CourseResource>(course);

            var newCourse = await _courseService.CreateCourse(courseToCreate);

            return RedirectToAction("Index");
   
        }

        public async Task<ActionResult<CourseModel>> Update(int id, [FromForm] SaveCourseModel saveCourseModel)
        {
            var validator = new SaveCourseModelValidator();
            var validationResult = await validator.ValidateAsync(saveCourseModel);

            var requestIsInvalid = id == 0 || !validationResult.IsValid;

            if (requestIsInvalid)
                return BadRequest(validationResult.Errors);

            var courseToBeUpdate = await _courseService.GetCourseById(id);

            if (courseToBeUpdate == null)
                return NotFound();

            var course = _mapper.Map<SaveCourseModel, CourseResource>(saveCourseModel);

            await _courseService.UpdateCourse(course, courseToBeUpdate);

            var updatedCourse = await _courseService.GetCourseById(id);
            var updatedCourseResource = _mapper.Map<CourseResource, CourseModel>(updatedCourse);

            return RedirectToAction("Index");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var course = await _courseService.GetCourseById(id);

            if (course == null)
                return NotFound();

            await _courseService.DeleteCourse(course);

            return RedirectToAction("Index");
        }


    }
}