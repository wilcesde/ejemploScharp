using System;

namespace oopExample
{
    class proyecto
    {
        //Atributos
        public string projectType { get; set; }

        // public void costoProyecto(string tipoProyecto)
        // {
        //     short precio = 0;
        //     if (tipoProyecto == "a" || tipoProyecto == "A")
        //     {
        //         precio = 10000;
        //     } else
        //     {
        //         if (tipoProyecto == "b" || tipoProyecto == "B")
        //         {
        //             precio = 20000;
        //         } else
        //         {
        //             precio = 5000;
        //         }
        //     }
            
        //     Console.WriteLine("El precio es: " + precio);
        // }

        public short costoProyecto(string tipoProyecto)
        {
            short precio = 0;
            if (tipoProyecto == "a" || tipoProyecto == "A")
            {
                precio = 10000;
            } else
            {
                if (tipoProyecto == "b" || tipoProyecto == "B")
                {
                    precio = 20000;
                } else
                {
                    precio = 5000;
                }
            }
            
            return precio;
        }

        
        public void mostrarResultado()
        {
            short precioSinIva = 0;
            short precioConIva = 0;
            precioSinIva = costoProyecto(projectType);
            precioConIva = (short) ( precioSinIva * 0.16 + precioSinIva);
            System.Console.WriteLine("El resultado es: " + precioConIva);
        }
    }
}