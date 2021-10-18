using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using puerta_de_ingreso.Mediciones;

namespace puerta_de_ingreso.Modelos
{
    public class Triangulo : Figura //herencia
    {
        private static string TipoDeFigura = @"Triangulo";

        public Triangulo(MedicionDeLados medicion) : base(medicion) // herencia
        {
            // la unica variable que tiene figura es la cantidad de lados,  ¿como llamo individualmente a  cada lado? 
        }

        public override string ObtenerTipo()
        {
            return ObtenerTipo(Triangulo.TipoDeFigura);
        }

        public override decimal CalcularArea() //polimorfismo
        {
            decimal semiperimetro;
            double res;
            decimal area;
            
            semiperimetro = (this.Medicion.Longitudes[0] + this.Medicion.Longitudes[1] + this.Medicion.Longitudes[2]) /
                            2;

            var valorABuscarRaiz = semiperimetro * (semiperimetro - this.Medicion.Longitudes[0]) * (semiperimetro - this.Medicion.Longitudes[1]) *
                (semiperimetro - this.Medicion.Longitudes[2]);
            
            res =  Math.Sqrt(Convert.ToDouble(valorABuscarRaiz));
            area = Convert.ToDecimal(res);
            return area;
        }


        public override decimal CalcularPerimetro()

        {
            decimal perimetro = this.Medicion.Longitudes.Sum();
            return perimetro;
        }

    }
}

    


