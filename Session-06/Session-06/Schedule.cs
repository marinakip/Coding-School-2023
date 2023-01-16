using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Schedule {

        // Properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid Professor { get; set; } 
        public DateTime Calendar { get; set; }

        // Constructors
        public Schedule() {

        }
        public Schedule(Guid iD) {
            ID = iD;
        }
        public Schedule(Guid iD, Guid courseID) {
            ID = iD;
            CourseID = courseID;
        }
        public Schedule(Guid iD, Guid courseID, Guid professor) {
            ID = iD;
            CourseID = courseID;
            Professor = professor;
        }
        public Schedule(Guid iD, Guid courseID, Guid professor, DateTime calendar) {
            ID = iD;
            CourseID = courseID;
            Professor = professor;
            Calendar = calendar;
        }
    }
}
