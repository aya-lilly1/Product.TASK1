using Product.TASK.Dtos;
using Product.TASK.Models;
using System.Collections.Generic;

namespace Product.TASK.Services
{
    public interface IEmployeeService
    {
        string Create(CreateEmployeeDto dto);
        string Delete(int Id);
        Employee Get(int Id);
        List<Employee> GetAll();
        string Update(UpdateEmployeeDto dto);
    }
}