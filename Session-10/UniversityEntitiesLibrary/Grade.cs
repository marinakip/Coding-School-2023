using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class Grade {

        #region Properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeNumber { get; set; }  //cannot take Grade as name Compiler Error CS0542
                                              //'user-defined type' : member names cannot be the same as their enclosing type
        #endregion Properties

        #region Constructors
        public Grade() { }
        public Grade(Guid id) {
            ID = id;
        }
        public Grade(Guid id, Guid studentID) {
            ID = id;
            StudentID = studentID;
        }

        public Grade(Guid id, Guid studentID, Guid courseID) {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
        }
        public Grade(Guid id, Guid studentID, Guid courseID, int gradeNumber) {
            ID = id;
            StudentID = studentID;
            CourseID = courseID;
            GradeNumber = gradeNumber;
        }
        #endregion Constructors
    }
}
