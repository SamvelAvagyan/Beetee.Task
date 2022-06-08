using Beetee.Task.Repository;
using Beetee.Task.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Beetee.Task.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await employeeRepository.GetAllAsync();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<Employee> Get(int id)
        {
            return await employeeRepository.GetByIdAsync(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async ValueTask Post([FromBody] Employee value)
        {
            await employeeRepository.AddAsync(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async ValueTask Put([FromBody] Employee value)
        {
            await employeeRepository.UpdateAsync(value);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async ValueTask Delete(int id)
        {
            await employeeRepository.DeleteAsync(id);
        }
    }
}
