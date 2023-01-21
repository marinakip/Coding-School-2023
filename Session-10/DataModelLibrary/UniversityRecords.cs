using UniversityEntitiesLibrary;

namespace DataModelLibrary {
    public class UniversityRecords : IUniversityRecords{
        #region Properties
        private University _university;
        private List<Student> _students;
        private List<Grade> _grades;
        private List<Course> _courses;
        private List<Schedule> _scheduledCourses;
        #endregion Properties

        #region  Loading & Save
        public void Loading() {
            Serializer serializer = new Serializer();
            try {
                //TODO: Check if file exists before serializing
                _university = serializer.DeserializeFromFile<University>("university.json");
                //_university = serializer.DeserializeFromFile<T>("university.json");
                // maybe check with GetType or typeof, to check if T is University
               // MessageBox.Show("File Loaded Successfully!");
            } catch (Exception) {
               // MessageBox.Show("File loading Failed");
                throw new Exception("File loading Failed");
            }
        }

        public void Save() {
            Serializer serializer = new Serializer();
            try {
                serializer.SerializeToFile(_university, "university.json");
               // MessageBox.Show("Save Done!");
            } catch (Exception exception) {
                //MessageBox.Show("Save Failed");
                throw;
            }
        }
        #endregion Loading & Save

        #region Students
        public void GenerateMultipleStudents(Random random, int times, List<Student> _students) {
            for (int i = 0; i < times; i++) {
                Student student = GenerateStudent(random);
                _students.Add(student);
            }
        }

        private Student GenerateStudent(Random random) {
            List<string> studentNames = new List<string>() { "John Doe", "Jane Doe", "John Dewey", "Paulo Pedersen", "Thalia Thomson", "Claudia Hilton" };
            Random randomNew = new Random();
            int randomIndex = randomNew.Next(0, studentNames.Count - 1);
            string studentName = studentNames[randomIndex];
            //TODO: FIX BUG - the same random name is generated more than once, maybe just iterate through the array (easy fix)
            //or keep random integer in a seperate array and check if exists(not needed, it is too much for this project)

            Student student = CreateStudent(random, studentName);
            return student;
        }

        private Student CreateStudent(Random random, string studentName) {
            // Gender, Undergraduate and UniversityID don't exist in the original class diagram
            // For this reason, they are not initialized here

            //Student has only id, name, age, registrationNumber

            Student student = new Student() {
                ID = Guid.NewGuid(),
                Name = studentName,                 //TODO: Maybe needs split later
                Age = random.Next(18, 30),         // univeristy students must be at least 18 , 30 was used as max value because previous rand gave many values > 50 
                RegistrationNumber = random.Next(10000000, 99999999)   // needs an integer so random.Next() is used
                                                                       // min and max value is used as a length check,
                                                                       // so the random registrationNumber has the same length for all students
            };
            return student;
        }

        #endregion Students

        //#region Grades
        //private void PopulateGrades(int times) {
        //    AddGradesToGridView(times);
        //}

        //private void AddGradesToGridView(int times) {
        //    _grades = new List<Grade>();
        //    createMultipleGrades(times);
        //    grvGrades.DataSource = _grades;
        //}

        #region Grades
        public void CreateMultipleGrades(int times, List<Grade> _grades, List<Student> _students) {
            for (int i = 0; i < times; i++) {
                Grade grade = CreateOneGrade(_students);
                _grades.Add(grade);
            }
        }

        private Grade CreateOneGrade(List<Student> _students) {
            Random random = new Random(DateTime.Now.Second);
            Console.WriteLine($"Students {_students.Count}");
            int randomIndex = random.Next(0, _students.Count - 1);
            Grade grade = CreateGrade(random, randomIndex);
            return grade;
        }

        // Grade has ID, StudentID, CourseID, GradeNumber
        private Grade CreateGrade(Random random, int randomStudentIndex) {
            Grade grade = new Grade() {
                ID = Guid.NewGuid(),
                StudentID = _students[randomStudentIndex].ID,
                CourseID = Guid.NewGuid(),
                GradeNumber = random.Next(1, 10)
            };
            return grade;
        }
        #endregion Grades

        #region Courses
        //private void PopulateCourses(int times) {
        //    AddCoursesToGridView(times);
        //}

        //private void AddCoursesToGridView(int times) {
        //    _courses = new List<Course>();
        //    createMultipleCourses(times);
        //    grvCourses.DataSource = _courses;
        //}

        public void CreateMultipleCourses(int times) {
            for (int i = 0; i < times; i++) {
                GenerateCourse();
            }
        }

        private void GenerateCourse() {
            string[] codes = { "MYY803", "MYY303", "MYY501", "MYY504", "MYE002", "MYE004" };
            string[] subjects = { "Software Engineering", "Theory of computation", "Computational Mathematics", "Machine Learning", "Advanced Software Development" };

            for (int k = 0; k < codes.Length; k++) {
                for (int m = 0; m < subjects.Length; m++) {
                    Course course = CreateOneCourse(codes[k], subjects[m]);
                    _courses.Add(course);
                }
            }
        }

        // Course has ID, Code, Subject
        private Course CreateOneCourse(string code, string subject) {
            Course course = new Course() {
                ID = Guid.NewGuid(),
                Code = code,
                Subject = subject,
            };
            return course;
        }
        #endregion Courses

        #region Populated Scheduled Courses
        public void PopulateScheduledCourses() {

        }
        #endregion Populated Scheduled Courses

    }
}