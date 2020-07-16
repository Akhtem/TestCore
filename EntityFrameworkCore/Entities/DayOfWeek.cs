using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Entities
{
    public class DayOfWeek
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual List<CourseInfo> CourseInfos { get; set; }
    }
}
