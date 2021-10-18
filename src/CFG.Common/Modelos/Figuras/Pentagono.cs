using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using puerta_de_ingreso.Mediciones;

namespace puerta_de_ingreso.Modelos
{
    public class Pentagono : Figura //herencia
    {
        private static string TipoDeFigura = @"Pentagono";

        public Pentagono(MedicionDeLados medicion) : base(medicion) // herencia
        {
            // la unica variable que tiene figura es la cantidad de lados,  ¿como llamo individualmente a  cada lado? 
        }

        public override string ObtenerTipo()
        {
            return ObtenerTipo(Pentagono.TipoDeFigura);
        }

        public override decimal CalcularArea() //polimorfismo
        {
            //area de pentagono REGULAR (todos sus lados son iguales)
            double perimetro = Convert.ToDouble(this.Medicion.Longitudes.Sum());
            double apotema = Convert.ToDouble(this.Medicion.Longitudes[0]) / (1.45); // 1.45 surge de calcular el angulo Seno  que es 360 / 5 Lados * 2;
            double area = (perimetro * apotema) / 2;
            return Convert.ToDecimal(area);
        }

        public override decimal CalcularPerimetro()

        {
            decimal perimetro = this.Medicion.Longitudes.Sum();
            return perimetro;
        }
    }
}

