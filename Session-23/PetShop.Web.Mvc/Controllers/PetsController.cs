﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.Web.Mvc.Models.Pet;
using System.Drawing;

namespace PetShop.Web.Mvc.Controllers {
    public class PetsController : Controller {
        private readonly IEntityRepository<Pet> _petRepository;

        public PetsController(IEntityRepository<Pet> petRepository) {
            _petRepository = petRepository;
        }

        // GET: PetsController
        public ActionResult Index() {
            var pets = _petRepository.GetAll();
            return View(model: pets);
        }

        // GET: PetsController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var pet = _petRepository.GetById(id);
            if (pet == null) {
                return NotFound();
            }

            var viewPet = new PetDetailsDto {
                Id = pet.Id,
                Breed = pet.Breed,
                AnimalType = pet.AnimalType,
                PetStatus = pet.PetStatus,
                Price = pet.Price,
                Cost = pet.Cost,
                Transactions = pet.Transactions.ToList()
            };
            return View(model: viewPet);
        }

        // GET: PetsController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetCreateDto pet) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbPet = new Pet(pet.Breed, pet.AnimalType, pet.PetStatus, pet.Price, pet.Cost);
                _petRepository.Add(dbPet);
                return RedirectToAction("Index");
            } catch {
                return View();
            }
        }

        // GET: PetsController/Edit/5
        public ActionResult Edit(int id) {
            var dbPet = _petRepository.GetById(id);
            if (dbPet == null) {
                return NotFound();
            }

            var viewPet = new PetEditDto {
                Id = dbPet.Id,
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost,
            };
            return View(model: viewPet);
        }

        // POST: PetsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetEditDto pet) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }

                var dbPet = _petRepository.GetById(id);
                if (dbPet == null) {
                    return NotFound();
                }

                dbPet.Breed = pet.Breed;
                dbPet.AnimalType = pet.AnimalType;
                dbPet.PetStatus = pet.PetStatus;
                dbPet.Price = pet.Price;
                dbPet.Cost = pet.Cost;

                _petRepository.Update(id, dbPet);
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetsController/Delete/5
        public ActionResult Delete(int id) {
            var dbPet = _petRepository.GetById(id);
            if (dbPet == null) {
                return NotFound();
            }
            var viewPet = new PetDeleteDto {
                Id = dbPet.Id,
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost,
            };
            return View(model: viewPet);
        }

        // POST: PetsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _petRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
