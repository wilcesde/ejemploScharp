using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VEHICULOS CESDE");
            Console.WriteLine("Marca: ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Referencia: ");
            string Referencia = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            short Modelo = short.Parse(Console.ReadLine());
            Console.WriteLine("Placa: ");
            string Placa = Console.ReadLine();

            //Instanciar la Class y usar los atributos. 
            //var vehiculoUno = new vehiculo();

            //vehiculoUno.marca = Marca;
            //vehiculoUno.referencia = Referencia;
            //vehiculoUno.modelo = Modelo;
            //vehiculoUno.placa = Placa;
            //De esta manera se esta dando un codigo redundante

            //Mejor forma de instanciar la class y usar los atributos
            //var vehiculoUno = new vehiculo() { marca=Marca, referencia=Referencia, modelo=Modelo, placa=Placa };
            //var vehiculoUno = new vehiculo() {
            //    marca = Marca,
            //    referencia = Referencia,
            //    modelo = Modelo,
            //    placa = Placa
            //};

            //var taxiUno = new taxi()
            //{
            //    marca = Marca,
            //    referencia = Referencia,
            //    modelo = Modelo,
            //    placa = Placa,
            //    //Banderazo =
            //};

            //Objeto camion con constructor Implicito
            //var camionUno = new camion()
            //{
                
            //};

            Console.WriteLine("Tipo Trailer: ");
            string Trailer = Console.ReadLine();

            //Objeto camion con constructor Explicito
            var camionUno = new camion(Marca, Trailer)
            {
                marca = Marca,
                tipoTrailer = Trailer,
                placa = Placa
            };

            //Invocando un metodo overriader
            camionUno.encender();

            //camionUno.ListaRutas();

            //Imprimir los atributos
            //Console.WriteLine(vehiculoUno.marca + " " + vehiculoUno.modelo);

            //Invocar el metodo
            //vehiculoUno.arrancar();

            //Console.WriteLine("El vehiculo " + vehiculoUno.marca + ", modelo " + vehiculoUno.modelo + " " + vehiculoUno.arrancar());
            //vehiculoUno.arrancar();

            //Invocar (usar) el contador (variable static). Se hace a traves de la class
            Console.WriteLine("Cantidad de Vehiculos: " + vehiculo.ContadorVehiculos);
            
            Console.ReadLine();
        }
    }
}
