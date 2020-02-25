using System;

namespace exampleAbstracOverrider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Animal Planet!");

            var dog = new Dog();
            var cat = new Cat();         

            Console.WriteLine("My Dog is " + dog.Correr() + " and makes " + dog.Aullar());
            Console.WriteLine("My Cat is " + cat.Correr() + " y makes " + cat.Aullar());

        }
    }
}
