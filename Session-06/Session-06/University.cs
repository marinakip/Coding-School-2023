using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class University : Institute {

        // Properties
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public Schedule[]? ScheduledCourse { get; set; }

        // Constructors
        public University() { }
        public University(Student[]? students) {
            Students = students;
        }
        public University(Student[]? students, Course[]? courses) {
            Students = students;
            Courses = courses;
        }
        public University(Student[]? students, Course[]? courses, Grade[]? grades) {
            Students = students;
            Courses = courses;
            Grades = grades;
        }
        public University(Student[]? students, Course[]? courses, Grade[]? grades, Schedule[]? scheduledCourse) {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduledCourse = scheduledCourse;
        }

        // Inheritance constuctors
        public University(Guid id) : base(id) { }
        public University(Guid id, string name) : base(id, name) { }
        public University(Guid id, string name, int yearsInService) : base(id, name, yearsInService) { }

        // Methods
        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime date) { }

    }    
}
