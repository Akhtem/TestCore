using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Resources.Course
{
    public class CourseResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int DayOfWeekId { get; set; }
        public string DayName { get; set; }

        public int TimeOfDayId { get; set; }
        public DateTime TimeOfDay { get; set; }
    }
}
