
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFullStackCrud.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public static List<Employees> workers = new List<Employees> {
            new Employees {
                Id = 1,
                FirstName= "Rizki",
                LastName= "Anandar Saputra",
                EmailAddress= "rizkianandar@gmail.com",
                PhoneNumber= "081234567890",
                HireDate= new DateTime(2022, 11, 09),
                Salary= 8000000,
            },
            new Employees {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "johndoe@gmail.com",
                PhoneNumber = "081456577625",
                HireDate = new DateTime(2022, 10, 10),
                Salary = 9000000,
            },
        };
        [HttpGet]
        public async Task<ActionResult<List<Employees>>> GetEmployees()
        {
            return Ok(workers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetSingleEmployees(int id)
        {
            var worker  = workers.FirstOrDefault(w => w.Id == id);
            if (worker == null)
            {
                return NotFound("The Name That You Was Looking Isn't Here");
            }
            return Ok(workers);
        }
    }
}
