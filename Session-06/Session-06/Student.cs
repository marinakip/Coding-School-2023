using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06
{
    public class Student : Person {

        // Properties
        public int RegistrationNumber { get; set; }
        public Course[]? Courses { get; set; }    

        // Constructors
        public Student() { }

        public Student(int registrationNumber) {
            RegistrationNumber = registrationNumber;
        }
        public Student(int registrationNumber, Course[]? courses) {
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }

        // Inheritance Constructors
        public Student(Guid id) : base(id) { }
        public Student(Guid id, string name) : base(id, name) { }
        public Student(Guid id, string name, int age) : base(id, name, age) { }


        // Methods
        public void Attend(Course course, DateTime date) { }    
        public void WriteExam(Course course, DateTime date) { }    


    }
}
