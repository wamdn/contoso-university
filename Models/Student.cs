using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
#nullable disable
        public Guid StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTimeOffset EnrollmentDate { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
