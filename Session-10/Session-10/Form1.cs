using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UniversityEntitiesLibrary;

namespace Session_10 {
    public partial class Form1 : Form {

        #region Properties
        private University _university;
        private List<Student> _students;
        private List<Grade> _grades;
        private List<Course> _courses;
        private List<Schedule> _scheduledCourses;
        #endregion Properties
        public Form1() {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            try {
                //TODO: Check if file exists before serializing
                _university = serializer.DeserializeFromFile<University>("university.json");
                //_university = serializer.DeserializeFromFile<T>("university.json");
                // maybe check with GetType , to check if T is University
                MessageBox.Show("File Loaded Successfully!");                
            } catch (Exception) {
                MessageBox.Show("File loading Failed");
                throw new Exception("File loading Failed");
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            try {
                serializer.SerializeToFile(_university, "university.json");
                MessageBox.Show("Save Done!");
            } catch (Exception exception) {
                MessageBox.Show("Save Failed");
                throw;
            }
        }

        private void grvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            //SetControlProperties();            
            PopulateStudents();
            PopulateGrades();
            PopulateCourses();
            PopulateScheduledCourses();

        }

        private void SetControlProperties() {
            ClearGridview(grvStudents, _students);
            ClearGridview(grvGrades, _grades);
            ClearGridview(grvCourses, _courses);
            ClearGridview(grvScheduledCourses, _scheduledCourses);
          
        }

        private void ClearGridview<T>(DataGridView gridView, List<T> list) {
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = list;
        }

        private void PopulateStudents() {
            _students = new List<Student>();
            Random random = new Random();

            // Gender, Undergraduate and UniversityID don't exist in the original class diagram
            // For this reason, they are not initialized here

            //Student has only id, name, age, registrationNumber

            Student student1 = new Student() {
                ID = Guid.NewGuid(),    
                Name = "Jane Doe", //TODO: Maybe needs split later
                Age = 19,
                RegistrationNumber= random.Next(10000000, 99999999)   // needs an integer so random.Next() is used
                //UniversityID = unis[0].ID,                          // min and max value is used as a length check,
                                                                      // so the random registrationNumber has the same length for all students
            };

            _students.Add(student1);

            Student student2 = new Student() {
                ID = Guid.NewGuid(),
                Name = "John Dewey", 
                Age = 21,
                RegistrationNumber = random.Next()
            };
            _students.Add(student2);

            Student student3 = new Student() {
                ID = Guid.NewGuid(),
                Name = "Paulo Pedersen", 
                Age = 20,
                RegistrationNumber = random.Next()        
            };
            _students.Add(student3);
            //_students.ToArray();

            grvStudents.DataSource = _students;  

          
        }


        private void PopulateGrades() {

        }

        private void PopulateCourses() {

        }

        private void PopulateScheduledCourses() {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }
    }
}