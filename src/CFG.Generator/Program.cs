using System;

namespace CFG.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var instrumento = new InstrumentoDeMedicion();

            var medicion = instrumento.ObtenerMedicion();

            Console.WriteLine("Lados: {0}", medicion.Count);
            foreach (var m in medicion)
            {
                Console.WriteLine("{0}", m);
            }
            Console.WriteLine("###");
            

            Console.ReadLine();
        }
    }
}
