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
    public class HumanResourceController : ControllerBase
    {
        private readonly IHumanResourceRepository humanResourceRepository;

        public HumanResourceController(IHumanResourceRepository humanResourceRepository)
        {
            this.humanResourceRepository = humanResourceRepository;
        }

        // GET: api/<HumanResourceController>
        [HttpGet]
        public async Task<IEnumerable<HumanResource>> Get()
        {
            return await humanResourceRepository.GetAllAsync();
        }

        // GET api/<HumanResourceController>/5
        [HttpGet("{id}")]
        public async Task<HumanResource> Get(int id)
        {
            return await humanResourceRepository.GetByIdAsync(id);
        }

        // POST api/<HumanResourceController>
        [HttpPost]
        public async ValueTask Post([FromBody] HumanResource value)
        {
            await humanResourceRepository.AddAsync(value);
        }

        // PUT api/<HumanResourceController>/5
        [HttpPut("{id}")]
        public async ValueTask Put([FromBody] HumanResource value)
        {
            await humanResourceRepository.UpdateAsync(value);
        }

        // DELETE api/<HumanResourceController>/5
        [HttpDelete("{id}")]
        public async ValueTask Delete(int id)
        {
            await humanResourceRepository.DeleteAsync(id);
        }
    }
}
