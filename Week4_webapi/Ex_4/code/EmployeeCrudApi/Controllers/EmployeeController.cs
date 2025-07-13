using Microsoft.AspNetCore.Mvc;
using EmployeeCrudApi.Models;

namespace EmployeeCrudApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Alice",
                Salary = 70000,
                Permanent = true,
                Department = new Department { Id = 1, Name = "IT" },
                Skills = new List<Skill>
                {
                    new Skill { Id = 1, Name = "C#" },
                    new Skill { Id = 2, Name = "SQL" }
                },
                DateOfBirth = new DateTime(1990, 1, 1)
            }
        };

        // GET all
        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return Ok(_employees);
        }

        // GET by id
        [HttpGet("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }

        // POST - Create
        [HttpPost]
        public ActionResult<Employee> Create([FromBody] Employee emp)
        {
            if (emp.Id <= 0)
                return BadRequest("Invalid employee id");
            if (_employees.Any(e => e.Id == emp.Id))
                return BadRequest("Employee already exists");

            _employees.Add(emp);
            return Ok(emp);
        }

        // PUT - Update
        [HttpPut("{id}")]
        public ActionResult<Employee> Update(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existing = _employees.FirstOrDefault(e => e.Id == id);
            if (existing == null)
                return BadRequest("Invalid employee id");

            // Update values
            existing.Name = updatedEmp.Name;
            existing.Salary = updatedEmp.Salary;
            existing.Permanent = updatedEmp.Permanent;
            existing.Department = updatedEmp.Department;
            existing.Skills = updatedEmp.Skills;
            existing.DateOfBirth = updatedEmp.DateOfBirth;

            return Ok(existing);
        }

        // DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound("Employee not found");

            _employees.Remove(emp);
            return Ok($"Employee with ID {id} deleted.");
        }
    }
}
