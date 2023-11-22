using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using firstapi1.models;

namespace firstapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class carController : ControllerBase
    {
        private car _car;
        private Iaccessories _accessories;
        
        private Iapilogger _logger;
        public carController(car c,Iapilogger logger,Iaccessories accessories)
        {

            _car = c;
            _accessories = accessories;
            _logger = logger;
            _logger.log("CarController instance is created");

        }
        [HttpGet("/drive")]
        public IActionResult Drive()
        {
            _logger.log("Driving() api called successfully");
            _logger.log("logger - 2 working verified");
            return Ok("Driving at 100kmph");
        }
        [HttpGet("/accessories")]
        public IActionResult accessories() 
        {
            _logger.log("accessories controller in  api is called successfully");
            
            return Ok("all accessories are available name it and buy it....thank you");
        }
    }
}
