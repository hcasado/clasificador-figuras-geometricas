using puerta_de_ingreso.Mediciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puerta_de_ingreso.Modelos
{
    public class Rectangulo : Figura // herencia
    {
        public Rectangulo(MedicionDeLados medicion) : base(medicion) // herencia
        {
        }

        public override string ObtenerTipo()
        {
            return ObtenerTipo("Rectangulo");
        }

        public override decimal CalcularArea() //polimorfismo
        {
            {
                decimal area;
                if (this.Medicion.Longitudes[0] != this.Medicion.Longitudes[1])

                {
                    area = this.Medicion.Longitudes[0] * this.Medicion.Longitudes[1];

                }
                else
                {
                    area = this.Medicion.Longitudes[0] * this.Medicion.Longitudes[2];

                }

                return area;
            }

        }

        public override decimal CalcularPerimetro() //polimorfismo
        {
            decimal perimetro = this.Medicion.Longitudes.Sum();
            return perimetro;
        }
    }
}
        
