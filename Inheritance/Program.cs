using System;
using System.Collections.Generic;
using System.Threading;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird ostrich = new Bird();
            ostrich.numberOfChromosomes = 80;
            ostrich.animalName = "Common Ostrich";
            ostrich.canFly = false;
            ostrich.isOmnivorous = true;
            ostrich.birdSong = "Chirp Chirp HISS!";
            ostrich.colors = "pink, black, white.";
            Console.WriteLine($"Our first animal is the {ostrich.animalName}. The {ostrich.animalName}" +
                $"has {ostrich.numberOfChromosomes} and it sounds like {ostrich.birdSong} and it is {ostrich.colors}.\n" +
                $"True or False: The {ostrich.animalName} can fly?");
            Thread.Sleep(2000);
            Console.WriteLine($"{ostrich.canFly}! While the ostrich can run up to 43 miles per hour it is unable to fly due to its weight.\n" +
                $"True or False: The {ostrich.animalName} is omnivorous?");
            Thread.Sleep(2000);
            Console.WriteLine($"{ostrich.isOmnivorous}! The {ostrich.animalName} eats mostly roots and flowers but sometimes lizards and insects.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile iguana = new Reptile();
            iguana.animalName = "Green Iguana";
            iguana.numberOfChromosomes = 34;
            iguana.numberOfLegs = 4;
            iguana.isColdBlooded = true;
            iguana.isHerbivorous = true;
            iguana.colors = "green";
            iguana.isAquatic = false;
            Console.WriteLine($"Our next animal is the {iguana.animalName}! The {iguana.animalName} has {iguana.numberOfChromosomes} chromosomes." +
                $"it is {iguana.colors} and it has {iguana.numberOfLegs} legs.\n");
            Console.WriteLine($"True or False: The {iguana.animalName} is cold blooded?");
            Thread.Sleep(2000);
            Console.WriteLine($"{iguana.isColdBlooded}! All iguanas are cold blooded, meaning they rely on the Sun for heat!\n" +
                $"True or False: {iguana.animalName}'s are herbivores?");
            Thread.Sleep(2000);
            Console.WriteLine($"{iguana.isHerbivorous}! The {iguana.animalName} is an herbivorous species!\n" +
                $"True or False: The {iguana.animalName} is an aquatic reptile?");
            Thread.Sleep(2000);
            Console.WriteLine($"{iguana.isAquatic}! THe {iguana.animalName} is an arboreal species meaning they live in trees!");




        }
    }
}
