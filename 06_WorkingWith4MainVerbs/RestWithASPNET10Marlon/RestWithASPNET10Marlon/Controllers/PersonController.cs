using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10Marlon.Model;
using RestWithASPNET10Marlon.Services;

namespace RestWithASPNET10Marlon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonServices _personServices;

        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personServices.FindById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var userCreated = _personServices.Create(person);
            if (userCreated == null)
                return NotFound();

            return Ok(userCreated);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            var userUpdated = _personServices.Update(person);
            if (userUpdated == null)
                return NotFound();

            return Ok(userUpdated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personServices.Delete(id);

            return NoContent();
        }
    }
}
