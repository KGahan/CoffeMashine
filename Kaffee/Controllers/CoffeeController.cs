using Coffee;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private readonly ILogger<CoffeeController> _logger;

        private static List<CoffeeMashine> coffeeMashines = new()
        {
            new CoffeeMashine() {Beans = 2, Water = 2}
        };

        public CoffeeController(ILogger<CoffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCoffeeMashine")]
        public bool GetCoffeMashine()
        {
            CoffeeMashine coffeeMashine = coffeeMashines[0];

            return coffeeMashine.makeCoffee(1, 2);
        }
    }
}