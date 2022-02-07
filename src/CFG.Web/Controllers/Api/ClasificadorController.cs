using CFG.Common.Modelos.Resultados;
using Microsoft.AspNetCore.Mvc;
using puerta_de_ingreso;
using puerta_de_ingreso.Mediciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CFG.Web.Controllers.Api
{
    [Route("api/clasificar")]
    [ApiController]
    public class ClasificadorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] List<decimal> mediciones)
        {
            var medicionDeLados = new MedicionDeLados(mediciones);
            var figura = FiguraFactory.Create(medicionDeLados);
            var resultado = new ResultadoClasificacion();
            resultado.Figura = figura.ObtenerTipo();
            resultado.Perimetro = figura.CalcularPerimetro();
            resultado.Area = figura.CalcularArea();

            return Ok(resultado);
        }
    }
}
