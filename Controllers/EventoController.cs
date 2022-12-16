using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
           
        }

        [HttpGet]
        public string Get()
        {
            return "Value";
        }

        [HttpPost]
        public string Post()
        {
            return "Value";
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return $"Value = {id}";
        }

        [HttpPut]
        public string Put(int id)
        {
            return $"Value = {id}";
        }
    }
}
