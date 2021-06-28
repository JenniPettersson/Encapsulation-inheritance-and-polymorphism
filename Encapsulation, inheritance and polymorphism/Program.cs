using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

namespace Encapsulation_inheritance_and_polymorphism
{
    class Program
    {

        static void Main(string[] args)
        {

            //Person person1 = new Person(34, "Sara", "Pettersson", 162, 60);
            // person1.Age = 34;
            // person1.FName = "Sara";
            // person1.LName = "Pettersson";
            // person1.Height = 162;
            // person1.Weight = 60;

            List<Animal> animals = new List<Animal>();
 
            animals.Add(new Horse("Pålle", 15, 400, "brown"));
            animals.Add(new Dog("Bliss", 5, 9, "blenheim"));
            animals.Add(new Hedgehog("Sonic", 15, 55, 567));
            animals.Add(new Worm("Slimey", 1, 1.0, 15));
            animals.Add(new Bird("Nam-Nam", 89, 1.2, 15));
            animals.Add(new Flamingo("Flammis", 2, 28.8, 1.5, 1));

            foreach (var a in animals)
            {
                Console.WriteLine(a.Stats());
                //DoSound;
            }
        }
    }

}
