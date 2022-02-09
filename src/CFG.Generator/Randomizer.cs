using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFG.Generator
{
    public class Randomizer
    {
        public int GetRandomInt()
        {
            var random = new Random();
            return random.Next(3, 6); //desde triangulos hasta pentagonos
        }

        public decimal GetRandomDecimal()
        {
            var random = new Random();
            var entero = random.Next(1, 100);
            var divisor = random.Next(1, entero);
            var basamento = entero * 1.0m / divisor;
            var suplemento = random.Next(1);
            var resultado = basamento + suplemento;
            return Math.Round(resultado, 2);
        }
    }
}
