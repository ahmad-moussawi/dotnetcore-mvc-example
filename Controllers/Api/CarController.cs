using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlKata.Execution;

namespace MvcExample.Controllers.Api
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly QueryFactory db;

        public CarController(QueryFactory db)
        {
            this.db = db;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var cars = await db.Query("cars").GetAsync();
            return Ok(new
            {
                data = cars
            });
        }
    }
}