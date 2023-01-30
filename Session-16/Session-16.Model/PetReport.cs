﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_16.Model.old_session_11_files.Pet;

namespace Session_16.Model {
    public class PetReport {

        public enum AnimalType {
            Bird,
            Cat,
            Dog
        }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Month { get; set; }

        [Required]
        public AnimalType TypeAnimal { get; set; }

        public int TotalSold { get; set; }

        public PetReport(int year, int month, AnimalType animalType) {
            Year = year;
            Month = month;
            TypeAnimal = animalType;
        }
    }
}
