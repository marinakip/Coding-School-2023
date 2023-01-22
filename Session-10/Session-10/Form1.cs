using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using UniversityEntitiesLibrary;
using DataModelLibrary;

namespace Session_10 {

    //TODO: --> Implement methods in UniversityEntitiesLibrary  <-- #HIGH_PRIORITY  #FIRST
    //TODO: --> Implement PopulateScheduledCourses(), also need to implement createMultipleProfessors and createProfessor and add to grid <-- #HIGH_PRIORITY #SECOND
   
    //TODO: Implement CellContentClick() for other grids #MEDIUM_PRIORITY
    //TODO: Implement bindingSource1_CurrentChanged() and grvStudents_CellContentClick() #MEDIUM_PRORITY

    //TODO: In SAVE maybe give the functionality to save different grids in different files (DONE for Save method)     #DONE

    //TODO: If this functionality is needed, in serializer we need to check what type is the json file for LOAD #LOW_PRIORITY

    //TODO: After observation, initialization methods for all grids have the same functionality
    //      Possible fix: Maybe for better refactoring, use something abstract like a Generic and then 
    //      in a switch check with typeof which class object we want to create  #LOW_PRIORITY

    //TODO: Add documentation comments #LOW_PRIORITY
    public partial class Form1 : Form {

        #region Properties
        private University _university;
        private List<Student> _students;
        private List<Grade> _grades;
        private List<Course> _courses;
        private List<Schedule> _scheduledCourses;
       
        #endregion Properties

        #region Form Initialization
        public Form1() {
            InitializeComponent();
        }
        #endregion Form Initialization

        #region Buttons Load & Save
        private void btnLoad_Click(object sender, EventArgs e) {
            IUniversityRecords universityRecords = new UniversityRecords();
            universityRecords.Loading();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            IUniversityRecords universityRecords = new UniversityRecords();
            universityRecords.Save(_university, _students, _grades, _courses, _scheduledCourses); // pass university as argument because Save() is in another class in a library
        }
        #endregion Buttons Load & Save

        #region Form Load
        private void Form1_Load(object sender, EventArgs e) {
            //SetControlProperties(); 
            PopulateForm();
        }
        #endregion Form Load

        #region SetControlProperties
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

        #endregion SetControlProperties

        #region Populate Form
        private void PopulateForm() {
            PopulateUniversityRecords();
        }

        public void PopulateUniversityRecords() {
            IUniversityRecords universityRecords = new UniversityRecords();
            _university = universityRecords.CreateUniversity();  
            
            PopulateStudents(5); 
            PopulateGrades(15);
            PopulateCourses(1);
            //PopulateScheduledCourses();   //not yet implemented
        }
        #endregion Populate Form

        #region Students
        private void PopulateStudents(int studentsNumber) {
            AddStudentsToGridView(studentsNumber);
        }

        private void AddStudentsToGridView(int studentNumber) {
            _students = new List<Student>();
            Random random = new Random(DateTime.Now.Millisecond);  // seed from the clock added to be more accurate for randomness
                                                                   // to keep generating the same result, a hard coded integer should be used as seed
            IUniversityRecords universityRecords = new UniversityRecords();
            universityRecords.GenerateMultipleStudents(random, studentNumber, _students); // max is 6 students because the array studentNames has 6 hard coded names                     
            // Possible fix for null students in university.json, GenerateMultipleStudents must return students list and then pass it in Save()
            grvStudents.DataSource = _students;
        }
        #endregion Students

        #region Grades
        private void PopulateGrades(int times) {
            AddGradesToGridView(times);
        }

        private void AddGradesToGridView(int times) {
            _grades = new List<Grade>();            
            IUniversityRecords universityRecords = new UniversityRecords();
            universityRecords.CreateMultipleGrades(times, _grades, _students);
            grvGrades.DataSource = _grades;
        }
        #endregion Grades

        #region Courses
        private void PopulateCourses(int times) {
            AddCoursesToGridView(times);
        }

        private void AddCoursesToGridView(int times) {
            _courses = new List<Course>();
            IUniversityRecords universityRecords = new UniversityRecords();
            universityRecords.CreateMultipleCourses(times, _courses);
            grvCourses.DataSource = _courses;
        }
        #endregion Courses


        //#region Populated Scheduled Courses

        //TODO: Implement Scheduled Courses
        //private void PopulateScheduledCourses() {

        //}
        //#endregion Populated Scheduled Courses

        #region Form methods not yet implemented

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {
            //TODO: IMPLEMENT to change source when Load() is pressed
            // When Load() is pressed call SetControlProperties to clear data that was randomly initialized
        }

        private void grvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //TODO: IMPLEMENT to show a MessageBox or a new form with student's data when cell student in clicked 
            //TODO: Also implement similar functionality to other grids if nessesary.
        }
        #endregion Form methods not yet implemented
    }
}