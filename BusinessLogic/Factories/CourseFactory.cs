using BusinessLogic.Resources.Course;
using EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Factories
{
    public class CourseFactory
    {
        public CourseResource Create(Course course , EntityFrameworkCore.Entities.DayOfWeek dayOfWeek , TimeOfDay timeOfDay)
        {
            return new CourseResource
            {
                Id = course.Id,
                Name = course.Name,
                Price = course.Price,
                DayOfWeekId = dayOfWeek.Id,
                DayName = dayOfWeek.Name,
                TimeOfDayId = timeOfDay.Id,
                TimeOfDay = timeOfDay.Time
            };
        }
    }
}
