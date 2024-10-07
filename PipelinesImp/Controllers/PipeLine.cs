using Microsoft.AspNetCore.Mvc;

namespace PipelinesImp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PipeLine : ControllerBase
    {
        [HttpGet(Name = "TestPipeLines")]
        public ActionResult Get()
        {
            return Ok("hello");
        }
    }
}
