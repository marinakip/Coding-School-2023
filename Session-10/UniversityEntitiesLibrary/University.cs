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
        public University() : base() { }
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
        public University(Guid id, String name, int yearsInService, Student[]? students) : base(id, name, yearsInService) {
            Students = students;
        }

        public University(Guid id, String name, int yearsInService, Student[]? students, Course[]? courses) : base(id, name, yearsInService) {
            Students = students;
            Courses = courses;
        }

        public University(Guid id, String name, int yearsInService, Student[]? students, Course[]? courses, Grade[]? grades) : base(id, name, yearsInService) {
            Students = students;
            Courses = courses;
            Grades = grades;
        }

        public University(Guid id, String name, int yearsInService, Student[]? students, Course[]? courses, Grade[]? grades, Schedule[]? scheduledCourse) : base(id, name, yearsInService) {
            Students = students;
            Courses = courses;
            Grades = grades;
            ScheduledCourse = scheduledCourse;
        }
        #endregion Inheritance Constructors

        #region Methods
        public Student[] GetStudents() {
            return Students;
        }
        public Course[] GetCourses() {
            return Courses;
        }
        public Grade[] GetGrades() {
            return Grades;
        }
        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime date) { }
        #endregion Methods
    }
}
