using System;

namespace CourseManager.Resources.Models
{
    public class CourseModel
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
