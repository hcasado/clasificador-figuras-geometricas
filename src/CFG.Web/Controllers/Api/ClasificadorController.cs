using CFG.Common.Modelos.Resultados;
using Microsoft.AspNetCore.Mvc;
using puerta_de_ingreso;
using puerta_de_ingreso.Mediciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CFG.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasificadorController : ControllerBase
    {
        // POST api/<ClasificadorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET RESPONSE BODY CONTENT");
        }

        // POST api/<ClasificadorController>
        [HttpPost]
        public IActionResult Post([FromBody] List<decimal> mediciones)
        {
            var medicionDeLados = new MedicionDeLados(mediciones);
            var figura = FiguraFactory.Create(medicionDeLados);
            var resultado = new ResultadoClasificacion();
            resultado.Figura = figura.ObtenerTipo();
            resultado.Perimetro = figura.CalcularPerimetro();
            resultado.Area = figura.CalcularArea();

            //return Ok("POST RESPONSE BODY CONTENT");
            return Ok(resultado);
        }
    }
}
