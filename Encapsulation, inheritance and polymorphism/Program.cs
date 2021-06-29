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
            animals.Add(new Wolfman("Hybbe", 24, 82, "Laos", 9));

            
            List<Dog> dogs = new List<Dog>();

            dogs.Add(new Dog("Bozo", 4, 60, "reddish brown"));
            //"Cannot convert från hmhm.Dog to hmhm.Horse" Hund och häst är olika objekt som inte hänger ihop   dogs.Add(new Horse("Ponny", 12, 450, "skimmel"));
            //Listan måste vara en Animal för att alla djuren ska kunna lagras tillsammans

            List<UserError> usererrors = new List<UserError>();

            usererrors.Add(new NumericInputError());
            usererrors.Add(new TextInputError());
            usererrors.Add(new SpecialInputError());
            usererrors.Add(new Special2InputError());


            foreach (var a in animals)
            {
                Console.WriteLine(a.Stats());

                //var checkType = a.GetType();

                if (a is IPerson temp10)
                {
                    Console.WriteLine(temp10?.Talk());
                }
                else if (a is Dog tempD)
                {
                    Console.WriteLine(tempD?.MyDogMethod());
                }
                else
                {
                Console.WriteLine(a.DoSound());
                }
            }

            //Skapar två listor. En för Animal med sju djur från olika klasser. En för Dog med en hund. Sen skapar jag en foreach-loop som skriver ut statsen för varje av de sju djuren
            //och även deras läten. I foreach-loopen gör jag en liten check om något av djuren är en IPerson, antog att det var den för Person har ingen Talk och jag har inga arvsregler
            //mellan Animal och Person. Och jag får min Wolfman att skriva något, med en nullcheck

            foreach (var e in usererrors)
            {
                Console.WriteLine(e.UEMessage());
            }

            //Varför är polymorfism viktigt att behärska?
            //Hur kan polymorfism förändra och förbättra kod via en bra struktur?
            //Vad är det för en skillnad på en Abstrakt klass och ett Interface?
        }
    }

}
