using System;

namespace oopExample
{
    class operaciones
    {
        //Atributos
        public int numUno { get; set; }
        public int numDos { get; set; }

        // public void sumar(int numeroUno, int numeroDos){
        //     int resultado = 0;
        //     resultado = numeroUno + numeroDos;
        //     System.Console.WriteLine("Resultado: " + resultado);
        // }

        public int calcularSuma(int numeroUno, int numeroDos){
            int resultadoSum = 0;
            resultadoSum = numeroUno + numeroDos;
            return resultadoSum;
        }

        public void imprimirSum(){
            System.Console.WriteLine(
                "Resultado pues es: " + 
                calcularSuma(numUno, numDos)
            );
        }

    }
}