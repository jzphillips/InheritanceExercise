using System;

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
            var Raven = new Bird();
            Raven.Name = "Raven";
            Raven.Legs = 2;
            Raven.Eyes = "Circular Pupils";
            Raven.WarmBlooded = true;
            
            Raven.Wings = 4.5;
            Raven.Beak = "Long";
            Raven.Claws = "Strong and Sharp";
            Raven.IsDomestic = false;
            
            Raven.BirdBrief();
            Raven.Questionnaire();
                        
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var Gecko = new Reptile();
            Gecko.Name = "Gecko";
            Gecko.Legs = 4;
            Gecko.Eyes = "Circular, yet have vertical pupils";
            Gecko.WarmBlooded = false;
            
            Gecko.IsLizard = true;
            Gecko.HasScales = true;
            Gecko.HasTeeth = true;
            Gecko.HasTail = true;
            
            Gecko.ReptileBriefing();
            
        }
    }
}
