﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Model.old_session_11_files
{
    public class Pet
    {
        public enum AnimalTypeEnum
        {
            Bird,
            Cat,
            Dog,
            None
        }
        public enum PetStatusEnum
        {
            OK,
            Unhealthy,
            Recovering
        }

        public Guid PetID { get; set; }
        public string Breed { get; set; }
        public AnimalTypeEnum AnimalType { get; set; }
        public PetStatusEnum Status { get; set; }
        public double Price { get; set; }
        public double Cost { get; set; }
        public string AnimalBreed
        {
            get { return string.Format("{0} {1}", AnimalType, Breed); }
            set { Breed = value; }
        }

        public Pet()
        {
            PetID = Guid.NewGuid();
            switch (AnimalType)
            {

                case AnimalTypeEnum.Cat:
                    Price = 100;
                    break;
                case AnimalTypeEnum.Dog:
                    Price = 120;
                    break;
                case AnimalTypeEnum.Bird:
                    Price = 200;
                    break;
            }
        }

        public Pet(Guid petID, string breed, AnimalTypeEnum animalType, PetStatusEnum status, double price, double cost)
        {
            PetID = petID;
            Breed = breed;
            AnimalType = animalType;
            Status = status;
            Price = price;
            Cost = cost;
        }
    }
}

