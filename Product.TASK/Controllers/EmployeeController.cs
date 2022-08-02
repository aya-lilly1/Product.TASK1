using Microsoft.AspNetCore.Mvc;
using Product.TASK.Dtos;
using Product.TASK.Services;

namespace Product.TASK.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            return Ok(_employeeService.Get(Id));
        }
        [HttpPost]
        public IActionResult Creat([FromBody]CreateEmployeeDto dto)
        {
            return Ok(_employeeService.Create(dto));
        }
        [HttpPut]
        public IActionResult Update([FromBody] UpdateEmployeeDto dto)
        {
            return Ok(_employeeService.Update(dto));
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Ok(_employeeService.Delete(Id));
        }
    }
}
