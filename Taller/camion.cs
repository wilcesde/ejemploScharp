using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class camion : vehiculo
    {
        public string tipoTrailer { get; set; }
        public string cabina { get; set; }

        //Mod private solo se puede usar en esta class
        //private string ruta { get; set; }

        public string ListaRutas()
        {
            return ruta.ToUpper();
        }

        //Constructor, que siempre un camion tenga Marca y Trailer
        public camion(string marcaC, string trailerC)
        {
            marca = marcaC;
            tipoTrailer = trailerC;
        }

        //Implementar un metodo abstract que esta en la superclass
        //Se hace con una palabra reservada denominada overrider (sobreescribir)
        public override void encender()
        {
            Console.WriteLine($"{modelo}, {tipoTrailer}, {cabina}");
        }

    }
}
