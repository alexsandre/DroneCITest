using Microsoft.AspNetCore.Mvc;

namespace csharpProjectAPI.Controllers
{
    [ApiController]
    [Route("Hello")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get(string name)
        {
            return $"Hello {(string.IsNullOrEmpty(name) ? "World" : name)}";
        }
    }
}