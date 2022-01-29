using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Course
    {
#nullable disable
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
