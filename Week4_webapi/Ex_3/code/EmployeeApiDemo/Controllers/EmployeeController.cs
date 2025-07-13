using EmployeeApiDemo.Filters;
using EmployeeApiDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET" }
                    },
                    DateOfBirth = new DateTime(1990, 5, 23)
                }
            };
        }

        [HttpGet("GetStandard")]
        [ProducesResponseType(typeof(List<Employee>), 200)]
        [ProducesResponseType(500)]
        [AllowAnonymous]
        public ActionResult<List<Employee>> GetStandard()
        {
            // Uncomment this line to test the exception filter:
            // throw new Exception("Simulated exception for testing");

            return Ok(_employees);
        }

        [HttpPost]
        public ActionResult<Employee> PostEmployee([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return Ok(emp);
        }
    }
}
