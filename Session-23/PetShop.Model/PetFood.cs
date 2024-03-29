﻿using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class PetFood : EntityBase {
        public PetFood(AnimalType animalType, decimal price, decimal cost)
        {
            AnimalType = animalType;
            Price = price;
            Cost = cost;

            Transactions = new List<Transaction>();
        }

        public AnimalType AnimalType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
