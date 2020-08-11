using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcExample.Services;
using SqlKata.Execution;

namespace MvcExample.Controllers.Api
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var cars = await carService.AllCars().GetAsync();

            // var activeCars = await carService.ActiveCars().GetAsync();

            return Ok(new
            {
                data = cars
            });
        }
    }
}