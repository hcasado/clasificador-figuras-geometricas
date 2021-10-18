using puerta_de_ingreso.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puerta_de_ingreso
{
    /// <summary>
    /// patron de diseño "factory"
    /// </summary>
    public abstract class FiguraFactory
    {
        public static Figura Create(Mediciones.MedicionDeLados medicion)
        {

            if (medicion.CantidadLados == 3)
            {
                return new Triangulo(medicion);
            }
            else if (medicion.CantidadLados == 4)
            {
                return new Rectangulo(medicion);
            }
            else if (medicion.CantidadLados == 5)
            {
                return new Pentagono(medicion);
            }
            else
            {
                return null;
            }
        }
    }
}
