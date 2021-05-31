using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPIDemo.Models;

namespace RestAPIDemo.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _service;

        public EmployeeController(IEmployeeRepository service)
        {
            _service = service;
        }
        
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_service.GetEmployees());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = _service.GetEmployeeById(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with Id: {id} was not found");
            
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee employee)
        {
            _service.AddEmployee(employee);
            return Created(
                HttpContext.Request.Scheme + "://" +
                HttpContext.Request.Host +
                HttpContext.Request.Path + "/" + employee.Id, employee);
        }
    }
}
