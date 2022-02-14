using gb.TimeSheets.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gb.TimeSheets.Controllers
{
    [ApiController]
    [Route("api/persons")]
    public class PersonController : ControllerBase
    {
        private IFakeRepository _personService;

        public PersonController(IFakeRepository personService)
        {
            _personService = personService;
        }
        /// <summary>
        /// Get person by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _personService.GetById(id);
        }
        /// <summary>
        /// Search person by first name (case sensitive)
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        [HttpGet("search")]
        public IEnumerable<Person> SearchByName(string firstName)
        {
            return _personService.GetByName(firstName);
        }

        /// <summary>
        /// Get persons for pagination 
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Person> Paginate(int skip, int take)
        {
            return _personService.GetFromTo(skip, take);
        }

        /// <summary>
        /// Create new person
        /// </summary>
        /// <param name="person"></param>
        [HttpPost]
        public void Create([FromBody]Person person)
        {
             _personService.Create(person);
        }

        /// <summary>
        /// Update person (updating in base by id)
        /// </summary>
        /// <param name="person"></param>
        [HttpPut]
        public void Update([FromBody] Person person)
        {
            _personService.Update(person);
        }

        /// <summary>
        /// Delete person (removing from base by id)
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _personService.Delete(id);
        }

    }
}
