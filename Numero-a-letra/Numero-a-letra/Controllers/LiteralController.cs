using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Numero_a_letra.Helpers;

namespace Numero_a_letra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        [Route ("NumLit")]
        public string LiteralGet(int number)
        {
            return Conversores.NumeroALetras(number);
        }
        [HttpPost]
        [Route("NumLit")]
        public string LiteralPost([FromHeader]int number)
        {
            return Conversores.NumeroALetras(number);
        }
    }
}
