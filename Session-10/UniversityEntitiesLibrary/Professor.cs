using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class Professor : Person {

        #region Properties
        public string? Rank { get; set; }
        public Course[]? Courses { get; set; }
        #endregion Properties

        #region Constructors
        public Professor() { }
        public Professor(string? rank) {
            Rank = rank;
        }
        public Professor(string? rank, Course[]? courses) {
            Rank = rank;
            Courses = courses;
        }
        #endregion Constructors

        #region Inheritance Constructors
        public Professor(Guid id) : base(id) { }
        public Professor(Guid id, string name) : base(id, name) { }
        public Professor(Guid id, string name, int age) : base(id, name, age) { }
        #endregion Inheritance Constructors

        #region Methods
        public void Teach(Course course, DateTime? date) { }
        public void SetGrade(int studentID, Guid courseID, int? grade) { }
        public void GetName() { }
        #endregion Methods
    }
}
