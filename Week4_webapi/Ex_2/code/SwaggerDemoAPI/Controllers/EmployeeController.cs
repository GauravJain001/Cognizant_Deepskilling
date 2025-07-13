using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemoAPI.Controllers
{
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string> { "John", "Jane" };

        [HttpGet(Name = "GetAllEmployees")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return employees;
        }

        [HttpPost]
        public IActionResult Post([FromBody] string name)
        {
            employees.Add(name);
            return Ok("Added " + name);
        }
    }
}
