using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ChildClasses
{
    class Cat : Animal
    {
        //        4. Cat(Child Class)
        //Inherits from the base animal type.
        //Has extra details specific to cats (color).
        //Makes a sound specific to cats.
        //Displays full cat details.

        public Cat(string name ,int age,string c):base(name,age)
        {
            Color = c;
        }
        public string Color { get; set; }

        public override string FeedAnimal()
        {
           return $"Cat is eating tuna\n";
        }

        public override string MakeSound()
        {
           return $"Cat Says Meow Meow \n";
        }
        public override string DisplayAnimalDetails()
        {
            return $"{base.DisplayAnimalDetails()}\nColor is {Color}\n ";
        }
    }
}
