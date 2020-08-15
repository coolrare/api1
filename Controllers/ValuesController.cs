using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AppSettings appSettings;
        public ValuesController(IOptions<AppSettings> appSettings)
        {
            this.appSettings = appSettings.Value;
        }

        // GET api/values
        [HttpGet("")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new List<string> {
                this.appSettings.Key1,
                this.appSettings.Key2
            };
        }
    }
}