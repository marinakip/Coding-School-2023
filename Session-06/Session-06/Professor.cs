using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Professor : Person {

        //Properties
        public string? Rank { get; set; } 
        public Course[]? Courses { get; set; }  

        //Constructors
        public Professor() { }
        public Professor(string? rank) {
            Rank = rank;
        }
        public Professor(string? rank, Course[]? courses) {
            Rank = rank;
            Courses = courses;
        }

        // Inheritance Constructors
        public Professor(Guid id) :base(id) { }
        public Professor(Guid id, string name) : base(id, name) { }
        public Professor(Guid id, string name, int age) : base(id, name, age) { }

            //Methods
            public void Teach(Course course, DateTime? date) { }
        public void SetGrade(int studentID, int courseID, double? grade) { }
        public void GetName() { }    

     }
}
