using System;

namespace Inheritance;

public class Reptile : Animal
{
    public bool IsLizard { get; set; }
    public bool HasScales { get; set; }
    public bool HasTeeth { get; set; }
    public bool HasTail { get; set; }
    public void ReptileBriefing()
    {
        Console.WriteLine($"{Name} is one scaly reptile. This is {HasScales}. Their eyes are {Eyes}, fun fact. It is {IsLizard} that {Name}s are lizards that run on {Legs} feet. They have tails and teeth? {HasTail}, and {HasTeeth}. But it is also {WarmBlooded} that they have warm blood, if anyone asks.");
    }
}