using Microsoft.AspNetCore.Mvc;

namespace webbShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    { 
         string namn = "TEST";
         
        [HttpGet]
        public IActionResult Get() {
            return Ok(namn);
        }
    }
}