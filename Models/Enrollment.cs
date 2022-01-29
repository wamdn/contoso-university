using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Enrollment
    {
#nullable disable
        [Key,Column(Order = 1)]
        public Guid StudentId { get; set; }

        [Key,Column(Order = 2)]
        public Guid CourseId { get; set; }
        public int Grade { get; set; }


        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
