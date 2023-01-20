using UniversityEntitiesLibrary;

namespace Session_10 {
    public partial class Form1 : Form {
        private University _university;
        public Form1() {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            try {
                _university = serializer.DeserializeFromFile<University>("university.json");
                //_university = serializer.DeserializeFromFile<T>("university.json");
                // maybe check with GetType , to check if T is University
                MessageBox.Show("File Loaded Successfully!");                
            } catch (Exception) {
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
    }
}