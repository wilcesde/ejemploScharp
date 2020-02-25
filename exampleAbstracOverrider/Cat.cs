using System;

namespace exampleAbstracOverrider
{
    class Cat : DomesticAnimal
    {
        // public void Correr(){
        //     Console.WriteLine("Esta corriendo...");
        // }

        // public void Aullar(){
        //     Console.WriteLine("Miau!!!");
        // }

        public override string Aullar(){
            return "Miau!!!";
        }
    }
}