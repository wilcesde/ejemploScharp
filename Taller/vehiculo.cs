using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller
{
    public abstract class vehiculo
    {
        //Atributos
        public string marca { get; set; }
        public string referencia { get; set; }
        //public short modelo { get; set; }
        private short modeloV;
        public short modelo {
            get { return modeloV; }
            set {
                if (value >= 2015)
                {
                    modeloV = value;
                }
                else
                {
                    Console.WriteLine("Modelo superior a 2014");
                }
            }
        }

        //public string placa { get; set; }
        private string placaV;
        public string placa {
            get { return placaV; }
            set {
                if (value.Length == 6)
                {
                    placaV = value;
                }
                else
                {
                    Console.WriteLine("Placa debe ser de 6 digitos");
                }
            }
        }

        //Mod protected solo se puede usar en esta class
        protected string ruta { get; set; }

        //Contructor Explicito
        //variable static. No depende del objeto si no de la class.
        //Se usa directamente desde la class
        public static int ContadorVehiculos = 0;

        //Constructor
        //static vehiculo()  //Solo se invoca una sola vez (en el primer llamado)
        public vehiculo() //public se ejecuta cada vez que se crea un objeto
        {
            //ContadorVehiculos = ContadorVehiculos + 1;
            //ContadorVehiculos++;  //Primero el valor luego lo incrementa
            ++ContadorVehiculos;  //Primero lo incrementa y luego el valor
        }

        //Metodos
        public void arrancar()
        {
            Console.WriteLine("El vehiculo " + marca + " modelo " + modelo + " arranco");
        }

        //Metodo Abstracto: Es un metodo que no tiene implementacion (estructura) solo tiene definicion
        //Para que un metodo sea abstract la class tambien debe serlo
        public abstract void encender();
    }
}
