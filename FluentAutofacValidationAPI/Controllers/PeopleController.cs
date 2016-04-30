using FluentAutofacValidationAPI.Infrastructure;
using FluentAutofacValidationAPI.Models;
using System.Web.Http;

namespace FluentAutofacValidationAPI.Controllers
{
    [RoutePrefix("api/people")]
    public class PeopleController : ApiController
    {
        [HttpPost]
        [Route("create")]
        [ValidateFilter]
        public IHttpActionResult CreatePerson(Person person)
        {
            return Ok("ok");
        }
    }
}