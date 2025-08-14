using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Task.ChildClasses
{
    class Dog : Animal
    {

        //        3. Dog(Child Class)
        //Inherits from the base animal type.
        //Has extra details specific to dogs (breed).
        //Makes a sound specific to dogs.
        //Displays full dog details.
        //Has more than one version of the 'play' action (different ways of calling it).]


    
        public string? Breed { get; set; }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public Dog(string name ,int age):base(name,age)
        {

        }
        public override string FeedAnimal()
        {
            return $"The Dog is eating\n";
        }

        public override string MakeSound()
        {
           return $"Dog says woof woof \n";
        }

        public override string DisplayAnimalDetails()
        {
            if (Breed is null)
            {
                return $"Dog Name is {Name}\nDog Age is {Age}";
            }
            else
            {
                return $"Dog Name is {Name}\nDog Age is {Age}\nBreed {Breed}";
            }
                
        }
        public void Play()
        {
            Console.WriteLine("The dog is playing ");
        }
        public void Play(string toy)
        {
            Console.WriteLine($"The dog is playing with a {toy}.");
        }
    }
}
