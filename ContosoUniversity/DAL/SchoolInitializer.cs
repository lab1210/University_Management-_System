using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ContosoUniversity.Models;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<Schoolcontext>
    {
        protected override void Seed(Schoolcontext context)
        {
            var students = new List<Student>
            {
            new Student{Firstname="Carson",LastName="Alexander",Enrollmentdate=DateTime.Parse("2005-09-01")},
            new Student{Firstname="Meredith",LastName="Alonso",Enrollmentdate=DateTime.Parse("2002-09-01")},
            new Student{Firstname="Arturo",LastName="Anand",Enrollmentdate=DateTime.Parse("2003-09-01")},
            new Student{Firstname="Gytis",LastName="Barzdukas",Enrollmentdate=DateTime.Parse("2002-09-01")},
            new Student{Firstname="Yan",LastName="Li",Enrollmentdate=DateTime.Parse("2002-09-01")},
            new Student{Firstname="Peggy",LastName="Justice",Enrollmentdate=DateTime.Parse("2001-09-01")},
            new Student{Firstname="Laura",LastName="Norman",Enrollmentdate=DateTime.Parse("2003-09-01")},
            new Student{Firstname="Nino",LastName="Olivetto",Enrollmentdate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,grade=grade.A},
            new Enrollment{StudentID=1,CourseID=4022,grade=grade.C},
            new Enrollment{StudentID=1,CourseID=4041,grade=grade.B},
            new Enrollment{StudentID=2,CourseID=1045,grade=grade.B},
            new Enrollment{StudentID=2,CourseID=3141,grade=grade.F},
            new Enrollment{StudentID=2,CourseID=2021,grade=grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,grade=grade.F},
            new Enrollment{StudentID=5,CourseID=4041,grade=grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,grade=grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}