using Microsoft.EntityFrameworkCore;
using Session_16.Model;
using Session_16.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.Orm.Repositories {
    public class EmployeeRepository : IEntityRepository<Employee> {
        public void Add(Employee entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Guid id, Employee entity) {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            dbEmployee.Name = entity.Name;
            dbEmployee.Surname = entity.Surname;
            dbEmployee.SalaryPerMonth = entity.SalaryPerMonth;  
            dbEmployee.TypeEmployee= entity.TypeEmployee;           
            context.SaveChanges();
        }
        public IList<Employee> GetAll() {
            using var context = new AppDbContext();
            return (IList<Employee>)context.Employees;
        }

        public Employee? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Employees.Where(employee => employee.EmployeeID == id)
                .Include(employee => employee.EmployeeID).SingleOrDefault();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var dbEmployee = context.Employees.Where(employee => employee.EmployeeID == id).SingleOrDefault();
            if (dbEmployee is null)
                return;
            context.Remove(dbEmployee);
            context.SaveChanges();
        }

        

        
    }
}
