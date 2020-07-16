using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseManager.Resources.Models
{
    public class SaveCourseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int DayOfWeekId { get; set; }
        public string DayName { get; set; }

        public int TimeOfDayId { get; set; }
        public DateTime TimeOfDay { get; set; }
    }
}
