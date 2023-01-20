using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class University : Institute {

        #region Properties
        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public Schedule[]? ScheduledCourse { get; set; }
        #endregion Properties

        #region Constructors
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
        #endregion Constructors

        #region Inheritance Constructors
        public University(Guid id) : base(id) { }
        public University(Guid id, string name) : base(id, name) { }
        public University(Guid id, string name, int yearsInService) : base(id, name, yearsInService) { }
        #endregion Inheritance Constructors

        #region Methods
        public void GetStudents() { }
        public void GetCourses() { }
        public void GetGrades() { }
        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime date) { }
        #endregion Methods
    }
}
