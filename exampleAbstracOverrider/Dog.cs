using System;

namespace exampleAbstracOverrider
{
    class Dog:DomesticAnimal
    {
        // public void Correr(){
        //     Console.WriteLine("Esta corriendo...");
        // }

        // public void Aullar(){
        //     Console.WriteLine("Wau Wau!!!");
        // }

        public override string Aullar(){
            return "Wau Wau!!!";
        }
    }
}
