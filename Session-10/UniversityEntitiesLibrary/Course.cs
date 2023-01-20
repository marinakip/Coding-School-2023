﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEntitiesLibrary {
    public class Course {

        #region Properties
        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }
        #endregion Properties

        #region Constructors
        public Course() { }
        public Course(Guid id) {
            ID = id;
        }
        public Course(Guid id, string code) {
            ID = id;
            Code = code;
        }
        public Course(Guid id, string code, string subject) {
            ID = id;
            Code = code;
            Subject = subject;
        }
        #endregion Constructors
    }
}
