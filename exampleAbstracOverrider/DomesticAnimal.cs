using System;

namespace exampleAbstracOverrider
{
    //class DomesticAnimal
    abstract class DomesticAnimal
    {
        public string Correr(){
            return "Is running...";
        }

        public abstract string Aullar();
    }
}