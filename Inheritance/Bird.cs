using System;

namespace Inheritance;

public class Bird : Animal
{
    public double Wings {get; set;}
    public string Beak { get; set; }
    public string Claws { get; set; }
    public bool IsDomestic { get; set; }

    public void BirdBrief()
    {
        Console.WriteLine($"The {Name} is a {Legs}-legged bird with quite {Eyes}. Their wingspan can reach up to {Wings} feet, and their claws are quite {Claws}.");
    }

    public void Questionnaire()
    {
        Console.WriteLine($"If anyone ever tells you that {Name}s are warm blooded, it is what? {WarmBlooded}, that's right. Now, whether or not they're domesticated, it is? {IsDomestic}, yes.");
    }
}