using System.Collections.Generic;
using System.Dynamic;
using System;
using Task.ChildClasses;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static input
            ////            6.Main Program
            ////Create a zoo with space for several animals.
            ////Create at least two different types of animals and add them to the zoo.
            ////Display all animals and their actions using the zoo’s method.
            ////Demonstrate more than one way of calling the 'play' action for dogs

            //Zoo zoo01 = new Zoo();
            //Cat c1 = new Cat("Lucy", 2, "White");
            //Dog d1 = new Dog("Jack", 7);

            //zoo01.AddNewAnimal(c1);
            //zoo01.AddNewAnimal(d1);
            //d1.Play("ball");
            //d1.Play();


            //zoo01.ShowAllAnimals();
            //zoo01.FeedAllAnimals();
            //zoo01.MakeAllSounds();


            #endregion

            #region Dynamic Input
            bool isParsed;
            int animalCount;
            Zoo zoo01 = new Zoo();


            do
            {
                Console.Write("Enter number of animals to add:int plz");
                isParsed = int.TryParse(Console.ReadLine(), out animalCount);
            } while (!isParsed);
        
            for (int i = 0; i < animalCount; i++)
            {
                Console.WriteLine($"Adding animal {i + 1}");

                string type;
                do
                {
                    Console.Write("Enter animal type cat or dog: ");
                    type = Console.ReadLine().ToLower();
                }
                while (type != "cat" && type != "dog");

                Console.Write("Enter name: ");
                string Name = Console.ReadLine();
                
                int Age;
                do
                {
                    Console.Write("Enter please the age");
                    isParsed = int.TryParse(Console.ReadLine(), out Age);
                }
                while (!isParsed);


                if (type == "cat")
                {
                    Console.Write("Enter color: ");
                    string color = Console.ReadLine();
                    Cat cat = new Cat(Name, Age, color);
                    zoo01.AddNewAnimal(cat);
                }
                else if (type == "dog")
                {
                    Console.Write("Enter breed: ");
                    string breed = Console.ReadLine();
                    Dog dog = new Dog(Name, Age);


                    Console.WriteLine("Do you want the dog to play? yes or no: ");
                    string playChoice = Console.ReadLine().ToLower();

                   
                    if (playChoice == "yes")
                    {

                        Console.Write("Do you want to specify a toy? yes or no: ");
                        string toyChoice = Console.ReadLine().ToLower();

                        if (toyChoice == "yes")
                        {
                            Console.Write("Enter toy name: ");
                            string toy = Console.ReadLine();
                            dog.Play(toy);
                        }
                        else
                        {
                            dog.Play();
                        }
                    }
                

                zoo01.AddNewAnimal(dog);
                }
            }
            Console.Clear();

            Console.WriteLine("Summarize what's happening in the Zoo");
            zoo01.ShowAllAnimals();
            zoo01.FeedAllAnimals();
            zoo01.MakeAllSounds();
           
            
        }




        #endregion


    }
}
