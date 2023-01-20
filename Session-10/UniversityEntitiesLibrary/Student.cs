using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class Student : Person {

        #region Properties
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }
        #endregion Properties

        #region Constructors
        public Student() :base() { }

        public Student(int registrationNumber) {
            RegistrationNumber = registrationNumber;
        }
        public Student(int registrationNumber, Course[]? courses) {
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }
        #endregion Constructors

        #region Inheritance Constructors
        public Student(Guid id) : base(id) { }
        public Student(Guid id, string name) : base(id, name) { }
        public Student(Guid id, string name, int age) : base(id, name, age) { }
        public Student(Guid id, String name, int age, int registrationNumber) : base(id, name, age) {
            RegistrationNumber = registrationNumber;
        }
        #endregion Inheritance Constructors


        #region Methods
        public void Attend(Course course, DateTime date) { }
        public void WriteExam(Course course, DateTime date) { }
        #endregion Methods
    }
}
