using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // ~~ DONE ~~ Create a class Animal
            // ~~ DONE ~~ give this class 4 members that all Animals have in common


            // ~~ DONE ~~ Create a class Bird
            // ~~ DONE ~~ give this class 4 members that are specific to Bird
            // ~~ DONE ~~ Set this class to inherit from your Animal Class

            // ~~ DONE ~~ Create a class Reptile
            // ~~ DONE ~~ give this class 4 members that are specific to Reptile
            // ~~ DONE ~~ Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bird1 = new Bird();
            bird1.WarmBlooded = true;
            bird1.HasLegs = "two";
            bird1.IsDomesticated = true;
            bird1.CarnivoreHerbivoreOrOmnivore = "herbivore";
            bird1.CanFly = false;
            bird1.DoPeopleEatThem = true;
            bird1.Color = "brown, white, and black";
            bird1.BirdOfPrey = false;

            Console.WriteLine($"I bet you are wondering a lot about ostriches. Let me "  +
                $"tell you all about them. \nFirst off they have {bird1.HasLegs} feet and can " +
                $"move pretty fast, \nbut if someone told you they saw one flying that is {bird1.CanFly} because they don't do that. \n" +
                $"While its {bird1.IsDomesticated} that you can domesticate them, their temprament doesn't make them " +
                $"the best pets. \nTheir feathers are usually colored {bird1.Color}, and like most birds and mammals it is " +
                $"{bird1.WarmBlooded} that they are warm blooded. \nTo me, one of nature's cruelest jokes is that while ostriches" +
                $" are so big it is {bird1.BirdOfPrey} that they hunt people or even other animals, in fact they are " +
                $"{bird1.CarnivoreHerbivoreOrOmnivore}s, and although its {bird1.DoPeopleEatThem} people eat them" +
                $" that kind of seems messed up to me.");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var bullfrog = new Reptile()
            {
               WarmBlooded = false,
               HasLegs = "four",
               IsDomesticated = false,
               CarnivoreHerbivoreOrOmnivore = "carnivore",
               DoesItHaveATail = false,
               IsItBig = "they are big for frogs, but small compared " +
               "to some other reptiles",
               IsItVenomous = true,
               NativeLand = "are native to North America"
            };
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine($"So I guess you could consider me a bullfrog guy, everywhere I go people always ask me for fun factoids " +
                $"about my favorite reptile. So I'll go ahead and tell you what I know! \n" +
                $"These {bullfrog.HasLegs} legged creatures {bullfrog.NativeLand} and if someone said they saw one with a tail " +
                $"you call them a liar because that is {bullfrog.DoesItHaveATail}. \n" +
                $"While it is {bullfrog.IsItVenomous} they are venomous if someone said they saw a warm-blooded bullfrog you call them " +
                $"a liar because that is {bullfrog.WarmBlooded}. They are cold-blooded\n" +
                $"Bullfrogs are {bullfrog.CarnivoreHerbivoreOrOmnivore}s, and {bullfrog.IsItBig}, but if someone told you they had a big" +
                $"farm full of domesticated bullfrogs you call them a liar because that is {bullfrog.IsDomesticated}. They are not an easily domesticated species");
        }
    }
}
