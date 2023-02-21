using FuelStation.EntityFramework.Context;
using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EntityFramework.Repositories {
    public class EmployeeRepository : IEntityRepository<Employee> {
        public void Add(Employee entity) {
            using var context = new FuelStationDbContext();
            if (entity.Id != Guid.Empty) {
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            }
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees
                .Where(Employee => Employee.Id == id)
                .Include(Employee => Employee.Transactions)
                .SingleOrDefault();
            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Employees.Remove(dbEmployee);
            context.SaveChanges();
        }

        public IList<Employee> GetAll() {
            using var context = new FuelStationDbContext();
            return context.Employees.Include(Employee => Employee.Transactions).ToList();
        }

        public Employee? GetById(Guid id) {
            using var context = new FuelStationDbContext();
            return context.Employees
                .Where(Employee => Employee.Id == id)
                .Include(Employee => Employee.Transactions)
                .SingleOrDefault();
        }

        public void Update(Guid id, Employee entity) {
            using var context = new FuelStationDbContext();
            var dbEmployee = context.Employees
                .Where(Employee => Employee.Id == id)
                .Include(Employee => Employee.Transactions)
                .SingleOrDefault();
            if (dbEmployee is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.HireDateStart = entity.HireDateStart;
            dbEmployee.HireDateEnd = entity.HireDateEnd;
            dbEmployee.SallaryPerMonth = entity.SallaryPerMonth;    
            dbEmployee.EmployeeType = entity.EmployeeType;  
            context.SaveChanges();
        }
    }
}
