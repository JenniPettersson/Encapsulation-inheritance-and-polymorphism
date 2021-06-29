using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Encapsulation_inheritance_and_polymorphism
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        //Om alla djur behöver ett nytt attribut så lägger vi det här

        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public abstract string DoSound();

        public virtual string Stats()
        {
            return $"Namn: {Name}, ålder: {Age}, vikt: {Weight}";
        }       

    }

    class Horse : Animal
    {
        public string Color { get; set; }

        string sound = "Gnägg";

        public Horse(string name, int age, double weight, string color) : base(name, age, weight)

        {
            Color = color;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, färg: {Color}";
        }

    }

    class Dog : Animal
    {
        public string FurColor { get; set; }

        string sound = "Vov vov";

        public Dog(string name, int age, double weight, string furcolor) : base(name, age, weight)
        {
            FurColor = furcolor;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, pälsfärg: {FurColor}";
        }

        public string MyDogMethod()
        {
            return "Valfri Dog-sträng";
        }
    }

    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        string sound = "Huff huff";

        public Hedgehog(string name, int age, double weight, int nrofspikes) : base(name, age, weight)
        {
            NrOfSpikes = nrofspikes;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, antal piggar: {NrOfSpikes}";
        }
    }

    class Worm : Animal
    {
        public int Lenght { get; set; }

        string sound = "Fsssff fsssff";

        public Worm(string name, int age, double weight, int lenght) : base(name, age, weight)
        {
            Lenght = lenght;
        }
        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, längd: {Lenght}";
        }

    }

    class Bird : Animal
    {
        //Om alla fåglar behöver ett nytt attribut så lägger vi det här
        public double WingSpan { get; set; }

        string sound = "Kraaw kraaaw";

        public Bird(string name, int age, double weight, double wingspan) : base(name, age, weight)
        {
            WingSpan = wingspan;
        }
        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, vingbredd: {WingSpan}";
        }

    }

    class Wolf : Animal
    {
        public string Country { get; set; }

        string sound = "Haaauuuuuuuoooooooooowl";

        public Wolf(string name, int age, double weight, string country) : base(name, age, weight)
        {
            Country = country;
        }
        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, land: {Country}";
        }
    }

    class Pelican : Bird
    {
        public int SizeOfBeak { get; set; }

        string sound = "Pelican pelican";

        public Pelican(string name, int age, double weight, double wingspan, int sizeofbeak) : base(name, age, weight, wingspan)
        {
            SizeOfBeak = sizeofbeak;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, näbbstorlek: {SizeOfBeak}";
        }

    }

    class Flamingo : Bird
    {
        public int Height { get; set; }

        string sound = "Flaaaamingo";

        public Flamingo(string name, int age, double weight, double wingspan, int height) : base(name, age, weight, wingspan)
        {
            Height = height;
        }

        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, höjd: {Height}";
        }

    }

    class Swan : Bird
    {
        public string Companion { get; set; }

        string sound = "Swan swan";
        public Swan(string name, int age, double weight, double wingspan, string companion) : base(name, age, weight, wingspan)
        {
            Companion = companion;
        }
        public override string DoSound()
        {
            return sound;
        }

        public override string Stats()
        {
            return $"{base.Stats()}, partner: {Companion}";
        }
    }

    class Wolfman : Wolf, IPerson
    {
        public int NrOfClaws { get; set; }

        string VoiceMessage = "This is I, Wolfman";

        public Wolfman(string name, int age, double weight, string country, int nrofclaws) : base(name, age, weight, country)
        {
         NrOfClaws = nrofclaws;
        }
        public override string Stats()
        {
        return $"{base.Stats()}, antal klor: {NrOfClaws}";
        }
        public string Talk()
        {
            return VoiceMessage;
        }

    }
}