using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InyeccionDeDependencias.Loggers;
using Microsoft.AspNetCore.Mvc;

namespace InyeccionDeDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMiLogger logger;

        public ValuesController(IMiLogger logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            logger.Log("Obteniendo un arreglo de valores");
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            logger.Log("Obteniendo un solo valor");
            return "value";
        }
    }

}
