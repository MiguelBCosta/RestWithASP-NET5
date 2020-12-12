using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNET.Model;
using RestWithASPNET.Bussines;

namespace RestWithASPNET.Controllers
{
    [ApiController]   
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonBussines _personBussines;

        public PersonController(ILogger<PersonController> logger, IPersonBussines personBussines)
        {
            _logger = logger;
            _personBussines = personBussines;
        }

        [HttpGet]
        public IActionResult GetAllPerson()
        {
            return Ok(_personBussines.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(long id)
        {
            var person = _personBussines.FindById(id);
            if (person is null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            if (person is null)
                return BadRequest();
            return Ok(_personBussines.Create(person));
        }

        [HttpPut]
        public IActionResult UpdatePerson([FromBody] Person person)
        {
            if (person is null)
                return BadRequest();
            return Ok(_personBussines.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(long id)
        {
            _personBussines.Delete(id);
            return NoContent();
        }
    }
}
