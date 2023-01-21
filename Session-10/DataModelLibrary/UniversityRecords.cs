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

    }
}