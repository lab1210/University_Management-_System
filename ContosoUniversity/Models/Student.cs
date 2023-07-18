using System;
using System.Collections.Generic;


namespace ContosoUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Firstname { get; set; }
        public DateTime Enrollmentdate { get; set; }
        public string Secret { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}