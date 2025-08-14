using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task.Interface;

namespace Task
{
    abstract class Animal : IFeedable
    {
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Animal()
        {

        }

        //        1. Animal(Base Class)
        //Should store basic information common to all animals(name, age).
        //Must provide a way for derived classes to define their own way of making sounds.
        //Must have a method to display animal details, but allow child classes to change how it works.
        //Must allow feeding animals through a common action.  [feeding]

        public string Name { get; set; }
        public int Age { get; set; }

        public abstract string MakeSound();

        public virtual string DisplayAnimalDetails ()
        {
            return $"Animal Name: {Name}\nAnimal Age {Age}\n";
        }

        public abstract string FeedAnimal();
       
    }
}
