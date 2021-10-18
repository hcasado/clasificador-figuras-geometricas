using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puerta_de_ingreso.Mediciones
{
    /// <summary>
    /// MedicionDeLados significa
    /// 
    /// Que estamos tomando la medida en unidad de longitud de varios lados
    /// 
    /// La unidad de medida es el metro
    /// 
    /// Se pueden almacenar varias longitudes
    /// 
    /// </summary>
  
    public class MedicionDeLados
    {
        public List<decimal> Longitudes { get; set; }

        public int CantidadLados {
            get {
                return this.Longitudes.Count;
            }
        }

        public MedicionDeLados()
        {
            this.Longitudes = new List<decimal>();
            
        }

        public MedicionDeLados(List<decimal> mediciones)
        {
            this.Longitudes = mediciones;
        }


        public decimal CalcularPerimetro()
        {
            return Longitudes.Sum();
        }
        
        
        public decimal CalcularAreaCuadrado()
        {
            return (Longitudes[0] *  Longitudes[0] );
        }

    }
}
