using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Relations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        // GET: BookController
        public ActionResult Get()
        {
            var book = new Book();
            var nameSubstring = book.NameSubstring;
            return Ok();
        }
    }
}
