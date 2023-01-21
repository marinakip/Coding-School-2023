using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEntitiesLibrary;

namespace DataModelLibrary {
    public interface IUniversityRecords {
        public void Loading();
        public void Save();
        public void CreateUniversity();
        public void GenerateMultipleStudents(Random random, int times, List<Student> _students);
        public void CreateMultipleGrades(int times, List<Grade> _grades, List<Student> _students);
        public void CreateMultipleCourses(int times, List<Course> _courses);
        public void PopulateScheduledCourses();
    }
}
