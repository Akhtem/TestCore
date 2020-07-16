using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Entities
{
    public class TimeOfDay
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual List<CourseInfo> CourseInfos { get; set; }
    }
}
