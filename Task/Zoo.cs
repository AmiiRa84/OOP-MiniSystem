using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task
{
    class Zoo
    {
        //        5. Zoo
        //Represents a place that can contain multiple animals.
        //Has a name.
        //Can store several animals at once.
        //Can add a new animal to its collection.
        //Can go through all stored animals and:
        //Show their details.
        //Make them produce their sound.
        //Feed them.
        public string Name { get; set; }
        private List<Animal> MixedAnimals=new List<Animal>();

        public void AddNewAnimal(Animal animal)
        {
            //MixedAnimals.Append(animal); mnf3t4444

            MixedAnimals.Add(animal); 

            Console.WriteLine($"Animal of type {animal.GetType().Name} is Added");
        }

        public void ShowAllAnimals()
        {
            #region Leh ma3rf4 a3ml loop 3l length lli mawgod delwa2ti
            //for (int i = 0; i < MixedAnimals.Length; i++)
            //{

            //} 
            #endregion

            foreach (Animal animal in MixedAnimals)
            {
                Console.WriteLine(animal.DisplayAnimalDetails());
            }
        }


             public void MakeAllSounds()
        {
            Console.WriteLine($"Animal Sounds");
            foreach (var animal in MixedAnimals)
            {
                ;
                Console.WriteLine(animal.MakeSound());
            }
        }

        public void FeedAllAnimals()
        {
            Console.WriteLine($"Feeding Animals");
            foreach (var animal in MixedAnimals)
            {
               
                Console.WriteLine(animal.FeedAnimal());
            }
        }
    }
}

