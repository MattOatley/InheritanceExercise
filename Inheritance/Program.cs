using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class



            //DONE!!
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            //DONE!!
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             * 
            
             */

            Bird hawk = new Bird() { NumLegs = 2, Beak = "Powerful Beak", CanFly = true, FeatherColor = "Brown", IsFriendly = false, Diet = "Carnivore", Wings = "Large", SkinType = "Feathers" };

            Reptile alligator = new Reptile() { NumLegs = 4, Vertebrae = "Yes it is a vertebrae", SkinType = "Scales", Diet = "Carnivore", IsFriendly = false, Aquatic = "Alligators can swim", ColdBlooded = "Alligators are coldblooded", Scales = "Smooth scales" };

            List<Animal> animals = new List<Animal>();

            animals.Add(alligator);
            animals.Add(hawk);

            foreach(Animal myAnimal in animals)
            {
                Console.WriteLine($"This animal is a {myAnimal.GetType().Name} it has {myAnimal.NumLegs} Legs, and its body is covered in {myAnimal.SkinType} . But is it friendly? {myAnimal.IsFriendly}, it is not friendly!");
            }
        }
    }
}
