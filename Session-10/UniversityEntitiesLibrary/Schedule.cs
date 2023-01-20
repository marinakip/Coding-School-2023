using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class Schedule {

        #region Properties
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid Professor { get; set; }
        public DateTime Calendar { get; set; }
        #endregion Properties

        #region Constructors
        public Schedule() {

        }
        public Schedule(Guid id) {
            ID = id;
        }
        public Schedule(Guid id, Guid courseID) {
            ID = id;
            CourseID = courseID;
        }
        public Schedule(Guid id, Guid courseID, Guid professor) {
            ID = id;
            CourseID = courseID;
            Professor = professor;
        }
        public Schedule(Guid id, Guid courseID, Guid professor, DateTime calendar) {
            ID = id;
            CourseID = courseID;
            Professor = professor;
            Calendar = calendar;
        }
        #endregion Constructors
    }
}
