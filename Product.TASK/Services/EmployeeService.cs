using Product.TASK.Data;
using Product.TASK.Dtos;
using Product.TASK.Exceptions;
using Product.TASK.Models;
using System.Collections.Generic;
using System.Linq;

namespace Product.TASK.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _db;
        public EmployeeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Employee> GetAll()
        {
            var employee = _db.Employees.ToList();
            return employee;

        }

        public Employee Get(int Id)
        {
            var employee = _db.Employees.Find(Id);
            return employee;

        }
        public string Create(CreateEmployeeDto dto)
        {
            var employee = new Employee();
            employee.Name = dto.name;
            employee.Salary = dto.salary;
            _db.Employees.Add(employee);
            _db.SaveChanges();
            return ("Done!");

        }
        public string Update(UpdateEmployeeDto dto)
        {
            var IsNExist = _db.Employees.Any(x => x.Name == dto.name);
            if (IsNExist)
            {
                throw new UpdateEmp();
            }
            if (dto.salary<500)
            {
                throw new salaryLess();

            }
            var employee = _db.Employees.Find(dto.Id);
            employee.Name = dto.name;
            employee.Salary = dto.salary;
            _db.Employees.Update(employee);
            _db.SaveChanges();
            return ("Done!");

        }
        public string Delete(int Id)
        {
            var IDFind =_db.Employees.Any(x => x.Id == Id);
            if (IDFind)
            {
                throw IdNotFond
            }
            var employee = _db.Employees.Find(Id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return ("Done!");

        }

    }
}
