using puerta_de_ingreso.Mediciones;
using puerta_de_ingreso.Modelos;
using System;

namespace puerta_de_ingreso
{
    /// <summary>
    /// Clase base para las figuras geometricas
    /// </summary>
    public abstract class Figura
    {

        /// <summary>
        /// cantidad de lados
        /// </summary>
        protected int Cantidad 
        { 
            get; 
            private set; 
        }
        //encapsulamiento


        protected MedicionDeLados Medicion;

        protected Figura(MedicionDeLados medicion)
        {
            this.Medicion = medicion;
            this.Cantidad = medicion.CantidadLados;    
        }

        public abstract string ObtenerTipo();
        
        public virtual string ObtenerTipo(string tipo)
        {
            return tipo;
        }

        public virtual decimal CalcularArea()
        {
            return 0;
        }


        public virtual decimal CalcularPerimetro()
        {
            return 0;
        }
    }
}
