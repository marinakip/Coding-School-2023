using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using UniversityEntitiesLibrary;
using DataModelLibrary;

namespace Session_10 {

    //TODO: After observation, initialization methods for all grids have the same functionality
    //      Possible fix: Maybe for better refactoring, use something abstract like a Generic and then 
    //      in a switch check with typeof which class object we want to create

    //TODO: In SAVE maybe give the functionality to save different grids in different files
    //TODO: If this functionality is needed, in serializer we need to check what type is the json file for LOAD
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
            universityRecords.Save();
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

        //TODO: implement
        //#region Populated Scheduled Courses
        //private void PopulateScheduledCourses() {

        //}
        //#endregion Populated Scheduled Courses

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }

        private void grvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}