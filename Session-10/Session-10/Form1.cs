using System.Runtime.CompilerServices;
using UniversityEntitiesLibrary;

namespace Session_10 {
    public partial class Form1 : Form {
        private University _university;
        private List<Student> _students;
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
            PopulateStudents();
        }

        private void PopulateStudents() {
            _students = new List<Student>();
            Random random = new Random();
            

            //It has id, name age registrationNumber
            Student student1 = new Student() {
                ID = Guid.NewGuid(),    
                Name = "Jane Doe", //TODO: Maybe Split it later
                Age = 19,
                RegistrationNumber= random.Next()
                //UniversityID = unis[0].ID,
            };

            _students.Add(student1);

            Student student2 = new Student() {
                ID = Guid.NewGuid(),
                Name = "John Dewey", //TODO: Maybe Split it later
                Age = 21,
                RegistrationNumber = random.Next()
            };
            _students.Add(student2);

            Student student3 = new Student() {
                ID = Guid.NewGuid(),
                Name = "Paulo Pedersen", //TODO: Maybe Split it later
                Age = 20,
                RegistrationNumber = random.Next()
                //UniversityID = unis[0].ID,                
            };
            _students.Add(student3);
            //_students.ToArray();
            grvStudents.DataSource= _students;  

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }
    }
}