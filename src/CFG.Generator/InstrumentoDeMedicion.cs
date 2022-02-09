using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFG.Generator
{
    public class InstrumentoDeMedicion
    {
        public List<decimal> ObtenerMedicion()
        {
            var resultado = new List<decimal>();
            var randomizer = new Randomizer();
            var lados = randomizer.GetRandomInt();

            for (var i = 0; i < lados; i++)
            {
                resultado.Add(randomizer.GetRandomDecimal());
            }

            return resultado;
        }
    }
}
