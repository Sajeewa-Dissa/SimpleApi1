using Microsoft.AspNetCore.Mvc;

namespace SimpleApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values/ e.g. https://localhost:7151/api/values/
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Console.WriteLine("hello to console"); //write to command window
            System.Diagnostics.Debug.WriteLine("hello to debug"); //write to VS Outpput window
            return new string[] { "value1","value2","value3" };
        }

        //GET api/values/5 e.g. https://localhost:7151/api/values/5
        [HttpGet("{id}")]
        public ContentResult Get(int id)
        {
            return Content($"Get returned {id}");
        }

        //POST api/values/postvalue
        [HttpPost]
        public ActionResult<string> PostValue([FromBody] string value)
        {
            return $"Called values Post method passing in string {value}";
        }
    }
}
