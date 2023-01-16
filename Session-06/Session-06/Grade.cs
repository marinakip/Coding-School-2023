using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Grade {

        // Properties
        public Guid ID { get; set; }
        public Guid StudentID { get; set; } 
        public Guid CourseID { get; set; }
        public int GradeNumber { get; set; }  //cannot take Grade as name Compiler Error CS0542
                                        //'user-defined type' : member names cannot be the same as their enclosing type

        // Constructors
        public Grade() { }
        public Grade(Guid iD) {
            ID = iD;
        }
        public Grade(Guid iD, Guid studentID) {
            ID = iD;
            StudentID = studentID;
        }

        public Grade(Guid iD, Guid studentID, Guid courseID) {
            ID = iD;
            StudentID = studentID;
            CourseID = courseID;
        }
        public Grade(Guid iD, Guid studentID, Guid courseID, int gradeNumber){
            ID = iD;
            StudentID = studentID;
            CourseID = courseID;
            GradeNumber = gradeNumber;
        }   
    }
}
