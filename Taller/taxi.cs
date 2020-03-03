using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class taxi : vehiculo //los dos : representan herencia
    {
        public short Banderazo { get; set; }

        public string listaRuta()
        {
            return ruta;
        }

        public override void encender()
        {
            Console.WriteLine($"{marca}, {Banderazo}");
        }
    }
}
