using System;

namespace oopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("Project Type:");
            //string projecttype = Console.ReadLine();

            //var proyectoUno = new proyecto()
            //{
                //projectType = projecttype,
            //};

            //proyectoUno.costoProyecto(proyectoUno.projectType);

            //proyectoUno.mostrarResultado();

            System.Console.WriteLine("Numero Uno");
            int nUno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Numero Dos");
            int nDos = int.Parse(Console.ReadLine());

            var myOperacion = new operaciones(){
                numUno = nUno,
                numDos = nDos
            };

            //myOperacion.sumar(myOperacion.numUno, myOperacion.numDos);

            myOperacion.imprimirSum();
        }
    }
}
