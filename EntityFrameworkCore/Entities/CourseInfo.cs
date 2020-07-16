using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Entities
{
    public class CourseInfo
    {
        public Guid Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int DayOfWeekId { get; set; }
        public virtual DayOfWeek DayOfWeek { get; set; }

        public int TimeOfDayId { get; set; }
        public virtual TimeOfDay TimeOfDay { get; set; }
    }
}
