using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;
using BooksAPI.Core;

namespace BooksAPI.Controllers
{
    public class BooksController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            using (var context = new BooksContext())
            {
                return Ok(await context.Books.Include(x => x.Reviews).ToListAsync());
            }
        }
    }
}