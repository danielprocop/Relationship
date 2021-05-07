using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PLDP.Relationship.Person
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly GetListOfPersonQueryHandler _getListOfPersonQueryHandler;

        public PeopleController(GetListOfPersonQueryHandler getListOfPersonQueryHandler)
        {
            this._getListOfPersonQueryHandler = getListOfPersonQueryHandler;
        }

        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            try
            {
              return  _getListOfPersonQueryHandler.Handle();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Some error was occured on GetListOfPersonQueryHandler");
            }
        }
    }
}
