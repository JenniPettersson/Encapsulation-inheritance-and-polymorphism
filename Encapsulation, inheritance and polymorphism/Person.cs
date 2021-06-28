using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_and_polymorphism
{
    class Person
    {
        public int Age { get; set; }

        public string FName { get; set; }
        
        public string LName { get; set; }

        public int Height { get; set; }

        public int Weight { get/*{ if...* Age LName FName*/; set; }

        public Person(int age, string fName, string lName, int height, int weight)
        {
            Height = height;
            Weight = weight;
            
            if (age < 1)
            {
                throw new ArgumentException("Age must be 1 or older");
            }
            else
            {
                Age = age;
            }
                       
            if (string.IsNullOrEmpty(FName))
            {
                throw new ArgumentException("First Name is mandatory");
            }

            else if (FName.Length < 2)
            {
                throw new ArgumentException("First Name is too short, it must be at least two characters long");
            }

            else if (FName.Length > 10)
            {
                throw new ArgumentException("First Name is too long, it must be 10 characters or less");
            }

            else
            {
                FName = fName;
            }

            if (string.IsNullOrEmpty(LName))
            {
                throw new ArgumentException("Last Name is mandatory");
            }

            else if (LName.Length < 3)
            {
                throw new ArgumentException("Last Name is too short, it must be at least three characters long");
            }

            else if (LName.Length > 15)
            {
                throw new ArgumentException("Last Name is too long, it must be 15 characters or less");
            }

            else
            {
                LName = lName;
            }

            }
        }
    }
