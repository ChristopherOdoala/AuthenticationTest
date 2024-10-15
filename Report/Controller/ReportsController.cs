using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Report.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetValues()
        {
            return Ok(new[] { "Report1", "Report2" });
        }
    }
}
